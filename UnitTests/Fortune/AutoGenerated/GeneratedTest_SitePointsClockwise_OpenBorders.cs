using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;
using static UnitTests.CommonTestUtilities;

namespace UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected clockwise-sorted <see cref="VoronoiPoint"/>`s.
    /// Specifically, that the <see cref="VoronoiSite.ClockwisePoints"/> contains the expected points in clockwise order.
    /// These tests are run without generating the border edges, i.e. <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SitePointsClockwise_OpenBorders
    {
        [Test]
        public void OnePointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        1                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(0, sites[0].ClockwisePoints.Count()); // #1
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #1
        }

        [Test]
        public void TwoPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(500, 300), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                        1                         
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 A-------------------------------------------------B
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                        2                         
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 500)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(300, 500), // #2
            };

            // 1000 ↑                        A                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              2         |         1               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #2
        }

        [Test]
        public void TwoPointsVerticalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 900))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 ↑                                  A               
            //      |                                  |               
            //  900 |                                  |               
            //      |                                  |               
            //  800 |                                  |               
            //      |                                  |               
            //  700 |                                  |               
            //      |                                  |               
            //  600 |                                  |               
            //      |                                  |               
            //  500 |                        2         |         1     
            //      |                                  |               
            //  400 |                                  |               
            //      |                                  |               
            //  300 |                                  |               
            //      |                                  |               
            //  200 |                                  |               
            //      |                                  |               
            //  100 |                                  |               
            //      |                                  |               
            //    0 └----------------------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(900, 500))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
        }

        [Test]
        public void ThreeConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 100), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 C-------------------------------------------------D
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                        3                         
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 900))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 300)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 300)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 300)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 300)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 100))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 500), // #3
            };

            // 1000 ↑              C                   A               
            //      |              |                   |               
            //  900 |              |                   |               
            //      |              |                   |               
            //  800 |              |                   |               
            //      |              |                   |               
            //  700 |              |                   |               
            //      |              |                   |               
            //  600 |              |                   |               
            //      |              |                   |               
            //  500 |    3         |         2         |         1     
            //      |              |                   |               
            //  400 |              |                   |               
            //      |              |                   |               
            //  300 |              |                   |               
            //      |              |                   |               
            //  200 |              |                   |               
            //      |              |                   |               
            //  100 |              |                   |               
            //      |              |                   |               
            //    0 └--------------D-------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(900, 500))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 0)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(100, 500))); // #3
        }

        [Test]
        public void FourConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
                new VoronoiSite(500, 600), // #2
                new VoronoiSite(500, 400), // #3
                new VoronoiSite(500, 200), // #4
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                        2                         
            //      |                                                  
            //  500 C-------------------------------------------------D
            //      |                                                  
            //  400 |                        3                         
            //      |                                                  
            //  300 E-------------------------------------------------F
            //      |                                                  
            //  200 |                        4                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 600))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 300)); // #3 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 300)); // #3 has F
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 400))); // #3
            Assert.AreEqual(2, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 300)); // #4 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 300)); // #4 has F
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 200))); // #4
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
                new VoronoiSite(600, 500), // #2
                new VoronoiSite(400, 500), // #3
                new VoronoiSite(200, 500), // #4
            };

            // 1000 ↑              E         C         A               
            //      |              |         |         |               
            //  900 |              |         |         |               
            //      |              |         |         |               
            //  800 |              |         |         |               
            //      |              |         |         |               
            //  700 |              |         |         |               
            //      |              |         |         |               
            //  600 |              |         |         |               
            //      |              |         |         |               
            //  500 |         4    |    3    |    2    |    1          
            //      |              |         |         |               
            //  400 |              |         |         |               
            //      |              |         |         |               
            //  300 |              |         |         |               
            //      |              |         |         |               
            //  200 |              |         |         |               
            //      |              |         |         |               
            //  100 |              |         |         |               
            //      |              |         |         |               
            //    0 └--------------F---------D---------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 500))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 500))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 1000)); // #3 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has F
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 500))); // #3
            Assert.AreEqual(2, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 300, 1000)); // #4 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 300, 0)); // #4 has F
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 500))); // #4
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(700, 300), // #2
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |              1                  ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                  2               
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 A'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(300, 300), // #2
            };

            // 1000 A,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                  1               
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |              2                  '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #2
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(600, 400), // #2
            };

            // 1000 ↑                                      ,B          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 |         1                  ,·'                   
            //      |                          ,'                      
            //  700 |                       ,·'                        
            //      |                     ,'                           
            //  600 |                  ,·'                             
            //      |                ,'                                
            //  500 |             ,·'                                  
            //      |           ,'                                     
            //  400 |        ,·'                  2                    
            //      |      ,'                                          
            //  300 |   ,·'                                            
            //      | ,'                                               
            //  200 A'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 200)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 1000)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 800))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 200)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 400))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(400, 400), // #2
            };

            // 1000 ↑         A,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                  1          
            //      |                     ',                           
            //  700 |                       '·,                        
            //      |                          ',                      
            //  600 |                            '·,                   
            //      |                               ',                 
            //  500 |                                 '·,              
            //      |                                    ',            
            //  400 |                   2                  '·,         
            //      |                                         ',       
            //  300 |                                           '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 200)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 800))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 400))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(400, 600), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,A
            //      |                                              ,'  
            //  700 |                                           ,·'    
            //      |                                         ,'       
            //  600 |                   2                  ,·'         
            //      |                                    ,'            
            //  500 |                                 ,·'              
            //      |                               ,'                 
            //  400 |                            ,·'                   
            //      |                          ,'                      
            //  300 |                       ,·'                        
            //      |                     ,'                           
            //  200 |                  ,·'                  1          
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------B'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 800)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 0)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 200))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 800)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 600))); // #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(600, 600), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,                                            
            //      |      ',                                          
            //  600 |        '·,                  2                    
            //      |           ',                                     
            //  500 |             '·,                                  
            //      |                ',                                
            //  400 |                  '·,                             
            //      |                     ',                           
            //  300 |                       '·,                        
            //      |                          ',                      
            //  200 |         1                  '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'A---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 800)); // #1 has B
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 200))); // #1
            Assert.AreEqual(2, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has B
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 600))); // #2
        }

        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(800, 200), // #3
            };

            // 1000 ↑                                 ,D               
            //      |                               ,'                 
            //  900 |                            ,·'                   
            //      |                          ,'                      
            //  800 |         1             ,·'                        
            //      |                     ,'                           
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,'  
            //  600 |             ,·'                           ,·'    
            //      |           ,'                            ,'       
            //  500 |        ,·'             2             ,·'         
            //      |      ,'                            ,'            
            //  400 |   ,·'                           ,·'              
            //      | ,'                            ,'                 
            //  300 A'                           ,·'                   
            //      |                          ,'                      
            //  200 |                       ,·'             3          
            //      |                     ,'                           
            //  100 |                  ,·'                             
            //      |                ,'                                
            //    0 └--------------B'---------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 300)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 300)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 700)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 200))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(200, 200), // #3
            };

            // 1000 ↑              A,                                  
            //      |                ',                                
            //  900 |                  '·,                             
            //      |                     ',                           
            //  800 |                       '·,             1          
            //      |                          ',                      
            //  700 B,                           '·,                   
            //      | ',                            ',                 
            //  600 |   '·,                           '·,              
            //      |      ',                            ',            
            //  500 |        '·,             2             '·,         
            //      |           ',                            ',       
            //  400 |             '·,                           '·,    
            //      |                ',                            ',  
            //  300 |                  '·,                           'D
            //      |                     ',                           
            //  200 |         3             '·,                        
            //      |                          ',                      
            //  100 |                            '·,                   
            //      |                               ',                 
            //    0 └---------------------------------'C--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 300, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 300)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 300)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 700)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 700, 0)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 200))); // #3
        }

        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
            };

            // 1000 ↑                            ,D                  ,C
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                   
            //      |      ,'                  ,'                      
            //  500 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //  400 A'                 ,·'        3                    
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 1000)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 600))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 400))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 |                  '·,        2        '·,         
            //      |                     ',                  ',       
            //  500 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //  400 |                   3        '·,                 'D
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 400)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 600))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 400))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(600, 400), // #2
                new VoronoiSite(400, 600), // #3
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,'  
            //  500 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  400 |                  ,·'        2        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        1          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 C'------------------D'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 0)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 200))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 0)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 400))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 600))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(400, 400), // #2
                new VoronoiSite(600, 600), // #3
            };

            // 1000 C,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 D,                 '·,        3                    
            //      | ',                  ',                           
            //  500 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  400 |        '·,        2        '·,                   
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         1        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'A------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 600)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 200))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 600)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 400))); // #2
            Assert.AreEqual(2, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has C
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 600))); // #3
        }

        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
                new VoronoiSite(800, 200), // #4
            };

            // 1000 ↑                            ,F                  ,E
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,'  
            //  500 |   ,·'                 ,·'                 ,·'    
            //      | ,'                  ,'                  ,'       
            //  400 A'                 ,·'        3        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        4          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 B'------------------C'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 1000)); // #1 has F
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 600))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 600)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has E
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 400))); // #3
            Assert.AreEqual(2, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 0)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 600)); // #4 has D
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 200))); // #4
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
                new VoronoiSite(200, 200), // #4
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 C,                 '·,        2        '·,         
            //      | ',                  ',                  ',       
            //  500 |   '·,                 '·,                 '·,    
            //      |      ',                  ',                  ',  
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         4        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'D------------------'E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(2, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 400)); // #1 has F
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(800, 800))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(600, 600))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has E
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(400, 400))); // #3
            Assert.AreEqual(2, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 600)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 0)); // #4 has D
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(200, 200))); // #4
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,D
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |              1        ,·'                        
            //      |                     ,'                           
            //  400 B-------------------A'                             
            //      |                   |                              
            //  300 |              2    |    3                         
            //      |                   |                              
            //  200 |                   |                              
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 0)); // #2 has C
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 400)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                   B                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                              
            //      |                   |                              
            //  700 |              2    |    1                         
            //      |                   |                              
            //  600 C-------------------A,                             
            //      |                     ',                           
            //  500 |              3        '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 600)); // #2 has C
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 600)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 ↑                             C                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 |                             |                    
            //      |                             |                    
            //  700 |                        3    |    2               
            //      |                             |                    
            //  600 |                            ,A-------------------B
            //      |                          ,'                      
            //  500 |                       ,·'        1               
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 D'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 600)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 600)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has C
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 600)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 D,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,        3               
            //      |                          ',                      
            //  400 |                            'A-------------------C
            //      |                             |                    
            //  300 |                        1    |    2               
            //      |                             |                    
            //  200 |                             |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------B-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has C
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 400)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #3
        }

        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  400 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 B'-----------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,        3                         
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |              1        #A------------------------D
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'        2                         
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 C'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 C,                                               ,B
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'A'        3               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,C
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                        2        ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 D------------------------A#        1               
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                        3        '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #3
        }

        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------B'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 300)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 0)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 100))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 300)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 300)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,        3                                   
            //      |      ',                                          
            //  600 |        '·,                                       
            //      |           ',                                     
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                     
            //  400 |        ,·'                                       
            //      |      ,'                                          
            //  300 |   ,·'        2                                   
            //      | ,'                                               
            //  200 C'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 300, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 800)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 200)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(100, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 200)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 800)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 ↑         C,                           ,B          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'A'        3               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 1000)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 900))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 700)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,C
            //      |                                              ,'  
            //  700 |                                  2        ,·'    
            //      |                                         ,'       
            //  600 |                                      ,·'         
            //      |                                    ,'            
            //  500 D----------------------------------A#        1     
            //      |                                    ',            
            //  400 |                                      '·,         
            //      |                                         ',       
            //  300 |                                  3        '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 200)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 800)); // #1 has C
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(900, 500))); // #1
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 800)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has D
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #2
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 700, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 200)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has D
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #3
        }

        [Test]
        public void FourPointsSurroundingAPointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(500, 700), // #5
            };

            // 1000 E,                                               ,H
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  600 |                  'A---------D'                   
            //      |                   |         |                    
            //  500 |              2    |    1    |    4               
            //      |                   |         |                    
            //  400 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 F'-----------------------------------------------'G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 400)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has G
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #3
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 400)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 0)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 1000)); // #4 has H
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #4
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 1000)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 1000)); // #5 has H
            Assert.That(sites[4].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #5
        }

        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 100), // #3
                new VoronoiSite(700, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 E,                                               ,H
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  400 |                  'A---------D'                   
            //      |                   |         |                    
            //  300 |              2    |    1    |    4               
            //      |                   |         |                    
            //  200 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //    0 └---------F'---------------------------'G---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 200)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 200)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 300))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 200)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 200)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 200)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 0)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 0)); // #3 has G
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 100))); // #3
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 200)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 400)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 0)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 800)); // #4 has H
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #4
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 400)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 400)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 800)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 800)); // #5 has H
            Assert.That(sites[4].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(100, 500), // #3
                new VoronoiSite(300, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                      ,E          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 F,                           ,·'                   
            //      | ',                       ,'                      
            //  700 |   '·,        2        ,·'                        
            //      |      ',             ,'                           
            //  600 |        'B---------A'                             
            //      |         |         |                              
            //  500 |    3    |    1    |    5                         
            //      |         |         |                              
            //  400 |        ,C---------D,                             
            //      |      ,'             ',                           
            //  300 |   ,·'        4        '·,                        
            //      | ,'                       ',                      
            //  200 G'                           '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'H---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 600)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 400)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 500))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 600)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 600)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 800)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 200)); // #3 has G
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(100, 500))); // #3
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 400)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 400)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 200)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 0)); // #4 has H
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 300))); // #4
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 400)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 800, 1000)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 800, 0)); // #5 has H
            Assert.That(sites[4].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 900), // #3
                new VoronoiSite(300, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         G,                           ,F          
            //      |           ',                       ,'            
            //  900 |             '·,        3        ,·'              
            //      |                ',             ,'                 
            //  800 |                  'C---------B'                   
            //      |                   |         |                    
            //  700 |              4    |    1    |    2               
            //      |                   |         |                    
            //  600 |                  ,D---------A,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        5        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 H'                                               'E
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 800)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 800)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 700))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 800)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 800)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 800)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 1000)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 1000)); // #3 has G
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 900))); // #3
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 800)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 1000)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 200)); // #4 has H
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(300, 700))); // #4
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 200)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 200)); // #5 has H
            Assert.That(sites[4].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(900, 500), // #3
                new VoronoiSite(700, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         H,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,'  
            //  700 |                       '·,        4        ,·'    
            //      |                          ',             ,'       
            //  600 |                            'D---------C'         
            //      |                             |         |          
            //  500 |                        5    |    1    |    3     
            //      |                             |         |          
            //  400 |                            ,A---------B,         
            //      |                          ,'             ',       
            //  300 |                       ,·'        2        '·,    
            //      |                     ,'                       ',  
            //  200 |                  ,·'                           'F
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------E'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 600)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has D
            Assert.That(sites[0].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 500))); // #1
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has F
            Assert.That(sites[1].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 300))); // #2
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 400)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 200)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 800)); // #3 has G
            Assert.That(sites[2].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(900, 500))); // #3
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 600)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 800)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 1000)); // #4 has H
            Assert.That(sites[3].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(700, 700))); // #4
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 400)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 200, 0)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 200, 1000)); // #5 has H
            Assert.That(sites[4].ClockwisePoints, Is.Ordered.Using(new ClockwisePointComparer(500, 500))); // #5
        }

    }
}
