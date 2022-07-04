﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SharpVoronoiLib
{
    public class VoronoiPlane
    {
        [PublicAPI]
        public IEnumerable<VoronoiSite> Sites { get; }

        [PublicAPI]
        public double MinX { get; }

        [PublicAPI]
        public double MinY { get; }

        [PublicAPI]
        public double MaxX { get; }

        [PublicAPI]
        public double MaxY { get; }


        private FortunesAlgorithm? _fortunesAlgorithm;

        
        public VoronoiPlane(IEnumerable<VoronoiSite> sites, double minX, double minY, double maxX, double maxY)
        {
            if (minX >= maxX) throw new ArgumentException();
            if (minY >= maxY) throw new ArgumentException();


            Sites = sites;
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }


        [PublicAPI]
        public static LinkedList<VoronoiEdge> TessellateOnce(IEnumerable<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));
            

            return new VoronoiPlane(sites, minX, minY, maxX, maxY).Tessellate(borderGeneration);
        }

        [PublicAPI]
        public LinkedList<VoronoiEdge> Tessellate(BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (_fortunesAlgorithm == null)
                _fortunesAlgorithm = new FortunesAlgorithm(this);
            
            return _fortunesAlgorithm.Run(borderGeneration);
        }
    }


    public enum BorderEdgeGeneration
    {
        DoNotMakeBorderEdges = 0,
        MakeBorderEdges = 1
    }
}