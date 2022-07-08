﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SharpVoronoiLib
{
    /// <summary>
    /// An Euclidean plane where a Voronoi diagram can be constructed from <see cref="VoronoiSite"/>s
    /// producing a tesselation of cells with <see cref="VoronoiEdge"/> line segments and <see cref="VoronoiPoint"/> vertices.
    /// </summary>
    public class VoronoiPlane
    {
        [PublicAPI]
        public List<VoronoiSite>? Sites { get; private set; }

        [PublicAPI]
        public List<VoronoiEdge>? Edges { get; private set; }

        [PublicAPI]
        public double MinX { get; }

        [PublicAPI]
        public double MinY { get; }

        [PublicAPI]
        public double MaxX { get; }

        [PublicAPI]
        public double MaxY { get; }


        private IPointGenerationAlgorithm? _pointGenerationAlgorithm;
        
        private ITessellationAlgorithm? _tessellationAlgorithm;
        
        private IBorderClippingAlgorithm? _borderClippingAlgorithm;
        
        private IBorderClosingAlgorithm? _borderClosingAlgorithm;
        
        private IRelaxationAlgorithm? _relaxationAlgorithm;
        
        private BorderEdgeGeneration _lastBorderGeneration;


        public VoronoiPlane(double minX, double minY, double maxX, double maxY)
        {
            if (minX >= maxX) throw new ArgumentException();
            if (minY >= maxY) throw new ArgumentException();

            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }


        [PublicAPI]
        public void SetSites(List<VoronoiSite> sites)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));

            Sites = sites;

            Edges = null;
        }

        [PublicAPI]
        public List<VoronoiSite> GenerateRandomSites(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));


            if (_pointGenerationAlgorithm == null)
                _pointGenerationAlgorithm = new RandomUniformPointGeneration();

            List<VoronoiSite> sites = _pointGenerationAlgorithm.Generate(MinX, MinY, MaxX, MaxY, amount);
            
            Sites = sites;

            Edges = null;
            
            return sites;
        }

        [PublicAPI]
        public List<VoronoiEdge> Tessellate(BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (Sites == null) throw new InvalidOperationException();

            _lastBorderGeneration = borderGeneration;

            // Tessellate
            
            if (_tessellationAlgorithm == null)
                _tessellationAlgorithm = new FortunesTessellation();

            List<VoronoiEdge> edges = _tessellationAlgorithm.Run(Sites, MinX, MinY, MaxX, MaxY);

            // Clip

            // todo: make clipping optional
            
            if (_borderClippingAlgorithm == null)
                _borderClippingAlgorithm = new GenericClipping();
            
            edges = _borderClippingAlgorithm.Clip(edges, MinX, MinY, MaxX, MaxY);

            // Enclose
            
            if (borderGeneration == BorderEdgeGeneration.MakeBorderEdges)
            {
                if (_borderClosingAlgorithm == null)
                    _borderClosingAlgorithm = new GenericBorderClosing();

                edges = _borderClosingAlgorithm.Close(edges, MinX, MinY, MaxX, MaxY, Sites);
            }
            
            // Done

            Edges = edges;
            
            return edges;
        }

        [PublicAPI]
        public List<VoronoiEdge> Relax(int iterations = 1, float strength = 1.0f, bool reTessellate = true)
        {
            if (Sites == null) throw new InvalidOperationException();
            if (Edges == null) throw new InvalidOperationException();
            if (iterations < 1) throw new ArgumentOutOfRangeException(nameof(iterations));
            if (strength <= 0f || strength > 1f) throw new ArgumentOutOfRangeException(nameof(strength));

            if (_relaxationAlgorithm == null)
                _relaxationAlgorithm = new LloydsRelaxation();

            for (int i = 0; i < iterations; i++)
            {
                // Relax once
                _relaxationAlgorithm.Relax(Sites, MinX, MinY, MaxX, MaxY, strength);

                if (i < iterations - 1 || // always have to tessellate if this isn't the last iteration, otherwise this makes no sense
                    reTessellate)
                {
                    // Re-tesselate with the new site locations
                    Tessellate(_lastBorderGeneration); // will set Edges
                }
            }

            return Edges;
        }


        [PublicAPI]
        public static List<VoronoiEdge> TessellateRandomSitesOnce(int numberOfSites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (numberOfSites < 0) throw new ArgumentOutOfRangeException(nameof(numberOfSites));


            VoronoiPlane plane = new VoronoiPlane(minX, minY, maxX, maxY);

            plane.GenerateRandomSites(numberOfSites);
            
            return plane.Tessellate(borderGeneration);
        }

        [PublicAPI]
        public static List<VoronoiEdge> TessellateOnce(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));


            VoronoiPlane plane = new VoronoiPlane(minX, minY, maxX, maxY);

            plane.SetSites(sites);
            
            return plane.Tessellate(borderGeneration);
        }
    }


    public enum BorderEdgeGeneration
    {
        DoNotMakeBorderEdges = 0,
        MakeBorderEdges = 1
    }
}
