using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s are returned as expected
    /// Specifically, that the result of <see cref="VoronoiPlane.Tessellate"/>() contains the expected edges.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_Edges_ClosedBorders
    {
        [Test]
        public void NoPoints()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |         1                                       |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                       1         |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 200), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                        1                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointArbitrary()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |         1                                       |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 800), // #1
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                  1              |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 300), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                       1         |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 200), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |              1                                  |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointOnBorderCentered()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 1                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 1000), // #1
            };

            // 1000 Y------------------------1------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 500), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 1
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X------------------------1------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointOnBorderOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 1                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 1000), // #1
            };

            // 1000 Y----------------------------------1--------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 300), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 1
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X--------------1----------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 700), // #1
            };

            // 1000 Z-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 1
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 0), // #1
            };

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y----------------------------------1--------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 300), // #1
            };

            // 1000 Y-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 1                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 1000), // #1
            };

            // 1000 X--------------1----------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void OnePointInCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 0), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 1-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 1000), // #1
            };

            // 1000 1-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 1000), // #1
            };

            // 1000 W-------------------------------------------------1
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------1
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count, "Expected: edge count 4");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                        1                        |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 A-------------------------------------------------B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                        2                        |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Y------------------------A------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              2         |         1              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Y----------------------------------A--------------X
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                                  |              |
            //      |                                  |              |
            //  500 |                        2         |         1    |
            //      |                                  |              |
            //  400 |                                  |              |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 C-------------------------------------------------D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                        3                        |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 300), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 700), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Y--------------C-------------------A--------------X
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |              |                   |              |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 |    3         |         2         |         1    |
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |              |                   |              |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 W--------------D-------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 700, 1000, 300, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 300, 0, 700, 0), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                        2                        |
            //      |                                                 |
            //  500 C-------------------------------------------------D
            //      |                                                 |
            //  400 |                        3                        |
            //      |                                                 |
            //  300 E-------------------------------------------------F
            //      |                                                 |
            //  200 |                        4                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count, "Expected: edge count 13");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge E-F"); // E-F
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 500), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 300), "Expected: has edge C-E"); // C-E
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge W-F"); // W-F
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 500), "Expected: has edge F-D"); // F-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 700), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Y--------------E---------C---------A--------------X
            //      |              |         |         |              |
            //  900 |              |         |         |              |
            //      |              |         |         |              |
            //  800 |              |         |         |              |
            //      |              |         |         |              |
            //  700 |              |         |         |              |
            //      |              |         |         |              |
            //  600 |              |         |         |              |
            //      |              |         |         |              |
            //  500 |         4    |    3    |    2    |    1         |
            //      |              |         |         |              |
            //  400 |              |         |         |              |
            //      |              |         |         |              |
            //  300 |              |         |         |              |
            //      |              |         |         |              |
            //  200 |              |         |         |              |
            //      |              |         |         |              |
            //  100 |              |         |         |              |
            //      |              |         |         |              |
            //    0 W--------------F---------D---------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count, "Expected: edge count 13");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge E-F"); // E-F
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 700, 1000, 500, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 1000, 300, 1000), "Expected: has edge C-E"); // C-E
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-F"); // W-F
            Assert.IsTrue(HasEdge(edges, 300, 0, 500, 0), "Expected: has edge F-D"); // F-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 700, 0), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 X------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |              1                  ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                  2              |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
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

            // 1000 A#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                  1              |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |              2                  '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-X"); // B-X
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

            // 1000 X--------------------------------------#B---------Z
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |         1                  ,·'                  |
            //      |                          ,'                     |
            //  700 |                       ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 |             ,·'                                 |
            //      |           ,'                                    |
            //  400 |        ,·'                  2                   |
            //      |      ,'                                         |
            //  300 |   ,·'                                           |
            //      | ,'                                              |
            //  200 A'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 200, 800, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
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

            // 1000 Y---------A#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                  1         |
            //      |                     ',                          |
            //  700 |                       '·,                       |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                                 '·,             |
            //      |                                    ',           |
            //  400 |                   2                  '·,        |
            //      |                                         ',      |
            //  300 |                                           '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 200, 1000, 1000, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge B-X"); // B-X
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,A
            //      |                                              ,' |
            //  700 |                                           ,·'   |
            //      |                                         ,'      |
            //  600 |                   2                  ,·'        |
            //      |                                    ,'           |
            //  500 |                                 ,·'             |
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'                       |
            //      |                     ,'                          |
            //  200 |                  ,·'                  1         |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 Z---------B#--------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 800, 200, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-X"); // B-X
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,                                           |
            //      |      ',                                         |
            //  600 |        '·,                  2                   |
            //      |           ',                                    |
            //  500 |             '·,                                 |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |                       '·,                       |
            //      |                          ',                     |
            //  200 |         1                  '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 800, 0, 0, 800), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 0), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void TwoPointsAgainstCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 400), // #1
                new VoronoiSite(600, 800), // #2
            };

            // 1000 A#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                  2                   |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |         1                  '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-A"); // Y-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(800, 400), // #2
            };

            // 1000 X------------------------------------------------#A
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                   1                  ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                  2         |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 B#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-A"); // Y-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(400, 200), // #2
            };

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                  1         |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                   2                  '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-A"); // Y-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 200), // #1
                new VoronoiSite(200, 600), // #2
            };

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |         2                  ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                  1                   |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count, "Expected: edge count 5");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-A"); // Y-A
        }

        [Test]
        public void TwoPointsAgainstCornerSlanted()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 900), // #2
            };

            // 1000 A##-----------------------------------------------Z
            //      |  ''·,,                                          |
            //  900 |       ''·,,                      2              |
            //      |            ''·,,                                |
            //  800 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  700 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  600 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  500 |                        1                      ''B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 300), // #2
            };

            // 1000 X-------------------------------------------------A
            //      |                                                '|
            //  900 |                                              ,' |
            //      |                                             ,   |
            //  800 |                                            ·    |
            //      |                                           '     |
            //  700 |                                         ,'      |
            //      |                                        ,        |
            //  600 |                                       ·         |
            //      |                                      '          |
            //  500 |                        1           ,'           |
            //      |                                   ,             |
            //  400 |                                  ·              |
            //      |                                 '               |
            //  300 |                               ,'           2    |
            //      |                              ,                  |
            //  200 |                             ·                   |
            //      |                            '                    |
            //  100 |                          ,'                     |
            //      |                         ,                       |
            //    0 Y------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 100), // #2
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 B,,                      1                        |
            //      |  ''·,,                                          |
            //  400 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  300 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  200 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  100 |              2                      ''·,,       |
            //      |                                          ''·,,  |
            //    0 Z-----------------------------------------------##A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 700), // #2
            };

            // 1000 Z------------------------B------------------------Y
            //      |                       '                         |
            //  900 |                     ,'                          |
            //      |                    ,                            |
            //  800 |                   ·                             |
            //      |                  '                              |
            //  700 |    2           ,'                               |
            //      |               ,                                 |
            //  600 |              ·                                  |
            //      |             '                                   |
            //  500 |           ,'           1                        |
            //      |          ,                                      |
            //  400 |         ·                                       |
            //      |        '                                        |
            //  300 |      ,'                                         |
            //      |     ,                                           |
            //  200 |    ·                                            |
            //      |   '                                             |
            //  100 | ,'                                              |
            //      |,                                                |
            //    0 A-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 900), // #2
            };

            // 1000 Z-----------------------------------------------##A
            //      |                                          ,,·''  |
            //  900 |              2                      ,,·''       |
            //      |                                ,,·''            |
            //  800 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  700 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  600 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  500 B''                      1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 500), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 700), // #2
            };

            // 1000 Y------------------------B------------------------Z
            //      |                         '                       |
            //  900 |                          ',                     |
            //      |                            ,                    |
            //  800 |                             ·                   |
            //      |                              '                  |
            //  700 |                               ',           2    |
            //      |                                 ,               |
            //  600 |                                  ·              |
            //      |                                   '             |
            //  500 |                        1           ',           |
            //      |                                      ,          |
            //  400 |                                       ·         |
            //      |                                        '        |
            //  300 |                                         ',      |
            //      |                                           ,     |
            //  200 |                                            ·    |
            //      |                                             '   |
            //  100 |                                              ', |
            //      |                                                ,|
            //    0 X-------------------------------------------------A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 500, 1000), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 100), // #2
            };

            // 1000 X-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                      ,,B
            //      |                                          ,,·''  |
            //  400 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  300 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  200 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  100 |       ,,·''                      2              |
            //      |  ,,·''                                          |
            //    0 A##-----------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 500), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Z-A"); // Z-A
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 300), // #2
            };

            // 1000 A-------------------------------------------------X
            //      |'                                                |
            //  900 | ',                                              |
            //      |   ,                                             |
            //  800 |    ·                                            |
            //      |     '                                           |
            //  700 |      ',                                         |
            //      |        ,                                        |
            //  600 |         ·                                       |
            //      |          '                                      |
            //  500 |           ',           1                        |
            //      |             ,                                   |
            //  400 |              ·                                  |
            //      |               '                                 |
            //  300 |    2           ',                               |
            //      |                  ,                              |
            //  200 |                   ·                             |
            //      |                    '                            |
            //  100 |                     ',                          |
            //      |                       ,                         |
            //    0 Z------------------------B------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(6, edges.Count, "Expected: edge count 6");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 500, 0), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 500, 0, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Z-A"); // Z-A
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

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |         1             ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,' |
            //  600 |             ,·'                           ,·'   |
            //      |           ,'                            ,'      |
            //  500 |        ,·'             2             ,·'        |
            //      |      ,'                            ,'           |
            //  400 |   ,·'                           ,·'             |
            //      | ,'                            ,'                |
            //  300 A'                           ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'             3         |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Y--------------B#---------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 300, 700, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 300, 0, 1000, 700), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge B-W"); // B-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 Y--------------A#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,             1         |
            //      |                          ',                     |
            //  700 B,                           '·,                  |
            //      | ',                            ',                |
            //  600 |   '·,                           '·,             |
            //      |      ',                            ',           |
            //  500 |        '·,             2             '·,        |
            //      |           ',                            ',      |
            //  400 |             '·,                           '·,   |
            //      |                ',                            ', |
            //  300 |                  '·,                           'D
            //      |                     ',                          |
            //  200 |         3             '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 W---------------------------------#C--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 1000, 1000, 300), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 700, 700, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 0), "Expected: has edge B-W"); // B-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 X----------------------------#D------------------#C
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                  |
            //      |      ,'                  ,'                     |
            //  500 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //  400 A'                 ,·'        3                   |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 B#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 |                  '·,        2        '·,        |
            //      |                     ',                  ',      |
            //  500 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //  400 |                   3        '·,                 'D
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,' |
            //  500 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  400 |                  ,·'        2        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        1         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 C#------------------D#----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 600, 400, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge D-X"); // D-X
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

            // 1000 C#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 D,                 '·,        3                   |
            //      | ',                  ',                          |
            //  500 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  400 |        '·,        2        '·,                  |
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         1        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 X----------------------------#A------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 0, 0, 600), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge D-X"); // D-X
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

            // 1000 X----------------------------#F------------------#E
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,' |
            //  500 |   ,·'                 ,·'                 ,·'   |
            //      | ,'                  ,'                  ,'      |
            //  400 A'                 ,·'        3        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        4         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 B#------------------C#----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(11, edges.Count, "Expected: edge count 11");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-E"); // B-E
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 600), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-E"); // D-E
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge E-F"); // E-F
            Assert.IsTrue(HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge F-X"); // F-X
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

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 C,                 '·,        2        '·,        |
            //      | ',                  ',                  ',      |
            //  500 |   '·,                 '·,                 '·,   |
            //      |      ',                  ',                  ', |
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         4        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 Y----------------------------#D------------------#E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(11, edges.Count, "Expected: edge count 11");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-E"); // B-E
            Assert.IsTrue(HasEdge(edges, 0, 600, 600, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-E"); // D-E
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge E-F"); // E-F
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge F-X"); // F-X
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

            // 1000 X------------------------------------------------#D
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |              1        ,·'                       |
            //      |                     ,'                          |
            //  400 B-------------------A'                            |
            //      |                   |                             |
            //  300 |              2    |    3                        |
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------C-----------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 400, 400, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 400, 1000, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 Y-------------------B-----------------------------X
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |              2    |    1                        |
            //      |                   |                             |
            //  600 C-------------------A,                            |
            //      |                     ',                          |
            //  500 |              3        '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 W------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 600, 400, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 600, 0, 600), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 600, 1000, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-X"); // D-X
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

            // 1000 W-----------------------------C-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 |                        3    |    2              |
            //      |                             |                   |
            //  600 |                            ,A-------------------B
            //      |                          ,'                     |
            //  500 |                       ,·'        1              |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 D#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 600, 600, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 600, 0, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge D-X"); // D-X
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

            // 1000 D#------------------------------------------------W
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,        3              |
            //      |                          ',                     |
            //  400 |                            'A-------------------C
            //      |                             |                   |
            //  300 |                        1    |    2              |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 X-----------------------------B-------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 400, 600, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 400, 1000, 400), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 400, 0, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge D-X"); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 800), // #1
                new VoronoiSite(100, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |    1                  ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                            |
            //      |                ,'                               |
            //  600 B--------------A'                                 |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 |    2         |         3                        |
            //      |              |                                  |
            //  300 |              |                                  |
            //      |              |                                  |
            //  200 |              |                                  |
            //      |              |                                  |
            //  100 |              |                                  |
            //      |              |                                  |
            //    0 Y--------------C----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 600, 0, 600), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 600, 300, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 300, 600, 700, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 900), // #1
                new VoronoiSite(400, 900), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 Y-----------------------------B-------------------X
            //      |                             |                   |
            //  900 |                   2         |         1         |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 C-----------------------------A,                  |
            //      |                               ',                |
            //  600 |                                 '·,             |
            //      |                                    ',           |
            //  500 |                   3                  '·,        |
            //      |                                         ',      |
            //  400 |                                           '·,   |
            //      |                                              ', |
            //  300 |                                                'D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 700, 600, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 700, 0, 700), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 700, 1000, 300), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 200), // #1
                new VoronoiSite(900, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 W----------------------------------C--------------Y
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                        3         |         2    |
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                                 ,A--------------B
            //      |                               ,'                |
            //  300 |                            ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'                  1    |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Z--------------D#---------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 400, 1000, 400), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 400, 700, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 700, 400, 300, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 100), // #1
                new VoronoiSite(600, 100), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 D,                                                |
            //      | ',                                              |
            //  600 |   '·,                                           |
            //      |      ',                                         |
            //  500 |        '·,                  3                   |
            //      |           ',                                    |
            //  400 |             '·,                                 |
            //      |                ',                               |
            //  300 |                  'A-----------------------------C
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |         1         |         2                   |
            //      |                   |                             |
            //    0 X-------------------B-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 300, 400, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 300, 1000, 300), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 300, 0, 700), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 800), // #1
                new VoronoiSite(900, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 Z--------------D#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,                  1    |
            //      |                          ',                     |
            //  700 |                            '·,                  |
            //      |                               ',                |
            //  600 |                                 'A--------------B
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                        3         |         2    |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------C--------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 600, 700, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 700, 600, 300, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 600), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 700, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 700, 0, 0, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 300, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 300, 1000, 1000, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 100), // #1
                new VoronoiSite(400, 100), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                ,D
            //      |                                              ,' |
            //  600 |                                           ,·'   |
            //      |                                         ,'      |
            //  500 |                   3                  ,·'        |
            //      |                                    ,'           |
            //  400 |                                 ,·'             |
            //      |                               ,'                |
            //  300 C-----------------------------A'                  |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                   2         |         1         |
            //      |                             |                   |
            //    0 Y-----------------------------B-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 300, 600, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 300, 0, 300), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 300, 1000, 700), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 600, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 600, 0, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 300), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 700), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 200), // #1
                new VoronoiSite(100, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 Y--------------C----------------------------------W
            //      |              |                                  |
            //  900 |              |                                  |
            //      |              |                                  |
            //  800 |              |                                  |
            //      |              |                                  |
            //  700 |              |                                  |
            //      |              |                                  |
            //  600 |    2         |         3                        |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 B--------------A,                                 |
            //      |                ',                               |
            //  300 |                  '·,                            |
            //      |                     ',                          |
            //  200 |    1                  '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 X---------------------------------#D--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 400, 300, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 300, 400, 700, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 400), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 300, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 300, 1000, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 700, 0), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 700, 0, 0, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 900), // #1
                new VoronoiSite(600, 900), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 X-------------------B-----------------------------Y
            //      |                   |                             |
            //  900 |         1         |         2                   |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |                  ,A-----------------------------C
            //      |                ,'                               |
            //  600 |             ,·'                                 |
            //      |           ,'                                    |
            //  500 |        ,·'                  3                   |
            //      |      ,'                                         |
            //  400 |   ,·'                                           |
            //      | ,'                                              |
            //  300 D'                                                |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 700, 400, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 700, 1000, 700), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 700, 0, 300), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 400, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 400, 1000, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 700), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 300), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 1000), "Expected: has edge D-X"); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 X------------------------D------------------------Y
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 B#-----------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,        3                        |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |              1        #A------------------------D
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'        2                        |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 C#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 C#-----------------------------------------------#B
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'A'        3              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 Y------------------------------------------------#C
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                        2        ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 D------------------------A#        1              |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                        3        '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------B#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 300, 200, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 300, 800, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 200, 0, 800, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,        3                                  |
            //      |      ',                                         |
            //  600 |        '·,                                      |
            //      |           ',                                    |
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                    |
            //  400 |        ,·'                                      |
            //      |      ,'                                         |
            //  300 |   ,·'        2                                  |
            //      | ,'                                              |
            //  200 C'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 800), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 300, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 200), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 W---------C#---------------------------#B---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'A'        3              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 700, 500, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,C
            //      |                                              ,' |
            //  700 |                                  2        ,·'   |
            //      |                                         ,'      |
            //  600 |                                      ,·'        |
            //      |                                    ,'           |
            //  500 D----------------------------------A#        1    |
            //      |                                    ',           |
            //  400 |                                      '·,        |
            //      |                                         ',      |
            //  300 |                                  3        '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 700, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Y-B"); // Y-B
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  600 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 B'                                               'C
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 700, 0, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 700, 1000, 200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 Y---------B#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                            |
            //      |                     ',                          |
            //  700 |                       '·,        3              |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                        1        #A--------------D
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'        2              |
            //      |                     ,'                          |
            //  200 |                  ,·'                            |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 W---------C#--------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 500, 200, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 500, 200, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 C,                                               ,B
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  300 |              2        'A'        3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 300, 1000, 800), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 300, 0, 800), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 Z--------------------------------------#C---------W
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |                            ,·'                  |
            //      |                          ,'                     |
            //  700 |              2        ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 D--------------A#        1                        |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |              3        '·,                       |
            //      |                          ',                     |
            //  200 |                            '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#B---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 500, 800, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 500, 800, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X
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

            // 1000 E#-----------------------------------------------#H
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  500 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  400 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 F#-----------------------------------------------#G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 600, 400, 400), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 400, 600, 400), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 600, 400, 600, 600), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 600, 600, 400, 600), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 400, 600, 0, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 400, 400, 0, 0), "Expected: has edge B-F"); // B-F
            Assert.IsTrue(HasEdge(edges, 600, 400, 1000, 0), "Expected: has edge C-G"); // C-G
            Assert.IsTrue(HasEdge(edges, 600, 600, 1000, 1000), "Expected: has edge D-H"); // D-H
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge E-F"); // E-F
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge G-H"); // G-H
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge H-E"); // H-E
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 E,                                               ,H
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  300 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  200 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------F#---------------------------#G---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count, "Expected: edge count 16");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 400, 400, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 200, 600, 200), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 600, 200, 600, 400), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 600, 400, 400, 400), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 400, 400, 0, 800), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 400, 200, 200, 0), "Expected: has edge B-F"); // B-F
            Assert.IsTrue(HasEdge(edges, 600, 200, 800, 0), "Expected: has edge C-G"); // C-G
            Assert.IsTrue(HasEdge(edges, 600, 400, 1000, 800), "Expected: has edge D-H"); // D-H
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 200, 0, 800, 0), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge G-W"); // G-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge W-H"); // W-H
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge H-Z"); // H-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Y--------------------------------------#E---------X
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 F,                           ,·'                  |
            //      | ',                       ,'                     |
            //  700 |   '·,        2        ,·'                       |
            //      |      ',             ,'                          |
            //  600 |        'B---------A'                            |
            //      |         |         |                             |
            //  500 |    3    |    1    |    5                        |
            //      |         |         |                             |
            //  400 |        ,C---------D,                            |
            //      |      ,'             ',                          |
            //  300 |   ,·'        4        '·,                       |
            //      | ,'                       ',                     |
            //  200 G'                           '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 W--------------------------------------#H---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count, "Expected: edge count 16");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 600, 200, 600), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 200, 600, 200, 400), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 200, 400, 400, 400), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 400, 400, 400, 600), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 400, 600, 800, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 200, 600, 0, 800), "Expected: has edge B-F"); // B-F
            Assert.IsTrue(HasEdge(edges, 200, 400, 0, 200), "Expected: has edge C-G"); // C-G
            Assert.IsTrue(HasEdge(edges, 400, 400, 800, 0), "Expected: has edge D-H"); // D-H
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 200), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge G-W"); // G-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 800, 0), "Expected: has edge W-H"); // W-H
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge H-Z"); // H-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X
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

            // 1000 W---------G#---------------------------#F---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        3        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  'C---------B'                  |
            //      |                   |         |                   |
            //  700 |              4    |    1    |    2              |
            //      |                   |         |                   |
            //  600 |                  ,D---------A,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        5        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 H'                                               'E
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count, "Expected: edge count 16");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 600, 600, 800), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 800, 400, 800), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 400, 800, 400, 600), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 400, 600, 600, 600), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 600, 600, 1000, 200), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 600, 800, 800, 1000), "Expected: has edge B-F"); // B-F
            Assert.IsTrue(HasEdge(edges, 400, 800, 200, 1000), "Expected: has edge C-G"); // C-G
            Assert.IsTrue(HasEdge(edges, 400, 600, 0, 200), "Expected: has edge D-H"); // D-H
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge G-W"); // G-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge W-H"); // W-H
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge H-Z"); // H-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X
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

            // 1000 Z---------H#--------------------------------------W
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,' |
            //  700 |                       '·,        4        ,·'   |
            //      |                          ',             ,'      |
            //  600 |                            'D---------C'        |
            //      |                             |         |         |
            //  500 |                        5    |    1    |    3    |
            //      |                             |         |         |
            //  400 |                            ,A---------B,        |
            //      |                          ,'             ',      |
            //  300 |                       ,·'        2        '·,   |
            //      |                     ,'                       ', |
            //  200 |                  ,·'                           'F
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 X---------E#--------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count, "Expected: edge count 16");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 400, 800, 400), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 800, 400, 800, 600), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 800, 600, 600, 600), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 600, 600, 600, 400), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 600, 400, 200, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 800, 400, 1000, 200), "Expected: has edge B-F"); // B-F
            Assert.IsTrue(HasEdge(edges, 800, 600, 1000, 800), "Expected: has edge C-G"); // C-G
            Assert.IsTrue(HasEdge(edges, 600, 600, 200, 1000), "Expected: has edge D-H"); // D-H
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge G-W"); // G-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge W-H"); // W-H
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge H-Z"); // H-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void FourEquidistantPointsInASquareAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(700, 700), // #4
            };

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              1         |         4              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              2         |         3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(400, 200), // #2
                new VoronoiSite(600, 200), // #3
                new VoronoiSite(600, 800), // #4
            };

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                   1    |    4                   |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                   2    |    3                   |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARectangleAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(200, 600), // #2
                new VoronoiSite(200, 400), // #3
                new VoronoiSite(800, 400), // #4
            };

            // 1000 Y------------------------C------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |         2              |              1         |
            //      |                        |                        |
            //  500 D------------------------A------------------------B
            //      |                        |                        |
            //  400 |         3              |              4         |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------E------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void FourEquidistantPointsInAKiteAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 B#-----------------------------------------------#E
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              4        #A#        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 C#-----------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count, "Expected: edge count 8");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-E"); // D-E
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge E-B"); // E-B
        }

        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 X----B--------------------------------------------Z
            //      |     '                                           |
            //  900 |      ',                                         |
            //      |        ,                                        |
            //  800 |         ·                                       |
            //      |          '                                      |
            //  700 |           ',           4                      ,,E
            //      |             ,                            ,,·''  |
            //  600 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  500 |    1           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  400 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  300 |       ,,·''         ',           3              |
            //      |  ,,·''                ,                         |
            //  200 C''                      ·                        |
            //      |                         '                       |
            //  100 |              2           ',                     |
            //      |                            ,                    |
            //    0 Y-----------------------------D-------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 400, 100, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 400, 0, 200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 400, 600, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 400, 400, 1000, 700), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 100, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 100, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(100, 700), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 Y---------C---------------------------------------X
            //      |          '                                      |
            //  900 |           ',           1                      ,,B
            //      |             ,                            ,,·''  |
            //  800 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  700 |    2           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  600 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  500 |       ,,·''         ',           4              |
            //      |  ,,·''                ,                         |
            //  400 D''                      ·                        |
            //      |                         '                       |
            //  300 |              3           ',                     |
            //      |                            ,                    |
            //  200 |                             ·                   |
            //      |                              '                  |
            //  100 |                               ',                |
            //      |                                 ,               |
            //    0 W----------------------------------E--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 600, 1000, 900), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 600, 200, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 600, 0, 400), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 400, 600, 700, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 900), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 1000, 900, 1000, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 W-------------------D-----------------------------Y
            //      |                    '                            |
            //  900 |                     ',           2              |
            //      |                       ,                         |
            //  800 |                        ·                      ,,C
            //      |                         '                ,,·''  |
            //  700 |              3           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  600 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  500 |                 ,,·''         ',           1    |
            //      |            ,,·''                ,               |
            //  400 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  300 E''                      4           ',           |
            //      |                                      ,          |
            //  200 |                                       ·         |
            //      |                                        '        |
            //  100 |                                         ',      |
            //      |                                           ,     |
            //    0 Z--------------------------------------------B----X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 600, 900, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 600, 1000, 800), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 600, 400, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 600, 600, 0, 300), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 900, 0), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 900, 0, 1000, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 Z--------------E----------------------------------W
            //      |               '                                 |
            //  900 |                ',                               |
            //      |                  ,                              |
            //  800 |                   ·                             |
            //      |                    '                            |
            //  700 |                     ',           3              |
            //      |                       ,                         |
            //  600 |                        ·                      ,,D
            //      |                         '                ,,·''  |
            //  500 |              4           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  400 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  300 |                 ,,·''         ',           2    |
            //      |            ,,·''                ,               |
            //  200 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  100 B''                      1           ',           |
            //      |                                      ,          |
            //    0 X---------------------------------------C---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 400, 0, 100), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 400, 800, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 400, 1000, 600), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 600, 400, 300, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 100), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 0, 100, 0, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 100), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 Z--------------------------------------------B----X
            //      |                                           '     |
            //  900 |                                         ,'      |
            //      |                                        ,        |
            //  800 |                                       ·         |
            //      |                                      '          |
            //  700 E,,                      4           ,'           |
            //      |  ''·,,                            ,             |
            //  600 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  500 |                 ''·,,         ,'           1    |
            //      |                      ''·,,   ,                  |
            //  400 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  300 |              3           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  200 |                        ·                      ''C
            //      |                       '                         |
            //  100 |                     ,'           2              |
            //      |                    ,                            |
            //    0 W-------------------D-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 400, 900, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 400, 1000, 200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 400, 400, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 600, 400, 0, 700), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 200), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 400, 0), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 400, 0, 0, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 700), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 900, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 900, 1000, 1000, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(100, 300), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 W----------------------------------E--------------Z
            //      |                                 '               |
            //  900 |                               ,'                |
            //      |                              ,                  |
            //  800 |                             ·                   |
            //      |                            '                    |
            //  700 |              3           ,'                     |
            //      |                         ,                       |
            //  600 D,,                      ·                        |
            //      |  ''·,,                '                         |
            //  500 |       ''·,,         ,'           4              |
            //      |            ''·,,   ,                            |
            //  400 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  300 |    2           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  200 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  100 |           ,'           1                      ''B
            //      |          ,                                      |
            //    0 Y---------C---------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 400, 1000, 100), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 400, 200, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 400, 0, 600), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 400, 400, 700, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 1000, 0, 200, 0), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 200, 0, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 600), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 1000), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 700, 1000), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 700, 1000, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 100), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 1000, 100, 1000, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 900), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 Y-----------------------------D-------------------W
            //      |                            '                    |
            //  900 |              2           ,'                     |
            //      |                         ,                       |
            //  800 C,,                      ·                        |
            //      |  ''·,,                '                         |
            //  700 |       ''·,,         ,'           3              |
            //      |            ''·,,   ,                            |
            //  600 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  500 |    1           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  400 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  300 |           ,'           4                      ''E
            //      |          ,                                      |
            //  200 |         ·                                       |
            //      |        '                                        |
            //  100 |      ,'                                         |
            //      |     ,                                           |
            //    0 X----B--------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 600, 100, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 600, 0, 800), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 400, 600, 600, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 400, 600, 1000, 300), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 800), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 600, 1000), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 600, 1000, 1000, 1000), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 300), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 100, 0), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 100, 0, 0, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(900, 700), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 X---------------------------------------C---------Y
            //      |                                      '          |
            //  900 B,,                      1           ,'           |
            //      |  ''·,,                            ,             |
            //  800 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  700 |                 ''·,,         ,'           2    |
            //      |                      ''·,,   ,                  |
            //  600 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  500 |              4           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  400 |                        ·                      ''D
            //      |                       '                         |
            //  300 |                     ,'           3              |
            //      |                    ,                            |
            //  200 |                   ·                             |
            //      |                  '                              |
            //  100 |                ,'                               |
            //      |               ,                                 |
            //    0 Z--------------E----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 600, 0, 900), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 600, 800, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 600, 1000, 400), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 600, 600, 300, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 0, 1000, 800, 1000), "Expected: has edge X-C"); // X-C
            Assert.IsTrue(HasEdge(edges, 800, 1000, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 1000, 400), "Expected: has edge Y-D"); // Y-D
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 0), "Expected: has edge D-W"); // D-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 300, 0), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 300, 0, 0, 0), "Expected: has edge E-Z"); // E-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 0, 900), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 0, 900, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void FivePointsInAForkedTallCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 700), // #5
            };

            // 1000 W---------C#---------------------------#D---------Z
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'B'        5              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 E------------------------A------------------------F
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count, "Expected: edge count 15");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 400, 500, 700), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 500, 400, 0, 400), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 500, 400, 1000, 400), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 500, 400, 500, 0), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge F-Z"); // F-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge D-C"); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(700, 300), // #5
            };

            // 1000 X-------------------E-----------------------------W
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                            ,C
            //      |                   |                          ,' |
            //  700 |    3              |              2        ,·'   |
            //      |                   |                     ,'      |
            //  600 |                   |                  ,·'        |
            //      |                   |                ,'           |
            //  500 G-------------------A--------------B#        1    |
            //      |                   |                ',           |
            //  400 |                   |                  '·,        |
            //      |                   |                     ',      |
            //  300 |    4              |              5        '·,   |
            //      |                   |                          ', |
            //  200 |                   |                            'D
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------F-----------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count, "Expected: edge count 15");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 400, 500, 400, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 400, 500, 400, 0), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 400, 500, 0, 500), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge F-Z"); // F-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge D-C"); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 900), // #3
                new VoronoiSite(300, 900), // #4
                new VoronoiSite(300, 300), // #5
            };

            // 1000 Y------------------------G------------------------X
            //      |                        |                        |
            //  900 |              4         |         3              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 F------------------------A------------------------E
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              5        ,B,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Z---------D#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count, "Expected: edge count 15");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 600, 500, 300), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 300, 800, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 300, 200, 0), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 500, 600, 1000, 600), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 500, 600, 0, 600), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 500, 600, 500, 1000), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge F-Z"); // F-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 200, 0, 800, 0), "Expected: has edge D-C"); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(900, 300), // #3
                new VoronoiSite(900, 700), // #4
                new VoronoiSite(300, 700), // #5
            };

            // 1000 Z-----------------------------F-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 D,                            |                   |
            //      | ',                          |                   |
            //  700 |   '·,        5              |              4    |
            //      |      ',                     |                   |
            //  600 |        '·,                  |                   |
            //      |           ',                |                   |
            //  500 |    1        #B--------------A-------------------G
            //      |           ,'                |                   |
            //  400 |        ,·'                  |                   |
            //      |      ,'                     |                   |
            //  300 |   ,·'        2              |              3    |
            //      | ,'                          |                   |
            //  200 C'                            |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 W-----------------------------E-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count, "Expected: edge count 15");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 500, 300, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 200), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 800), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 600, 500, 600, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 600, 500, 600, 1000), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 600, 500, 1000, 500), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge W-E"); // W-E
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge F-Z"); // F-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Z-D"); // Z-D
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 200), "Expected: has edge D-C"); // D-C
        }

        [Test]
        public void FivePointsInAForkedStubbyCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 500), // #5
            };

            // 1000 C#-----------------------------------------------#D
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'B'        5              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 E------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count, "Expected: edge count 13");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge C-E"); // C-E
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge F-D"); // F-D
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge D-C"); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedStubbyCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedStubbyCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(500, 300), // #5
            };

            // 1000 X--------------E---------------------------------#C
            //      |              |                               ,' |
            //  900 |              |                            ,·'   |
            //      |              |                          ,'      |
            //  800 |              |                       ,·'        |
            //      |              |                     ,'           |
            //  700 |    3         |         2        ,·'             |
            //      |              |                ,'                |
            //  600 |              |             ,·'                  |
            //      |              |           ,'                     |
            //  500 G--------------A---------B#        1              |
            //      |              |           ',                     |
            //  400 |              |             '·,                  |
            //      |              |                ',                |
            //  300 |    4         |         5        '·,             |
            //      |              |                     ',           |
            //  200 |              |                       '·,        |
            //      |              |                          ',      |
            //  100 |              |                            '·,   |
            //      |              |                               ', |
            //    0 Y--------------F---------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count, "Expected: edge count 13");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 500, 500, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge B-D"); // B-D
            Assert.IsTrue(HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-G"); // A-G
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge C-E"); // C-E
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-X"); // E-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-G"); // X-G
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge G-Y"); // G-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge F-D"); // F-D
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-C"); // D-C
        }

        [Test]
        public void SixPointsInADoubleCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 500), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(300, 100), // #5
                new VoronoiSite(700, 100), // #6
            };

            // 1000 W------------------------H------------------------Z
            //      |                        |                        |
            //  900 |              1         |         2              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 C------------------------B------------------------G
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3         |         4              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 D------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              5         |         6              |
            //      |                        |                        |
            //    0 X------------------------E------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(17, edges.Count, "Expected: edge count 17");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 700), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 700, 0, 700), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 700, 1000, 700), "Expected: has edge B-G"); // B-G
            Assert.IsTrue(HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge B-H"); // B-H
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 300), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge D-X"); // D-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 1000, 300, 1000, 700), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge G-Z"); // G-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-H"); // Z-H
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge H-W"); // H-W
        }

        /// <summary>
        /// This test basically repeats <see cref="SixPointsInADoubleCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void SixPointsInADoubleCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(500, 700), // #3
                new VoronoiSite(500, 300), // #4
                new VoronoiSite(100, 700), // #5
                new VoronoiSite(100, 300), // #6
            };

            // 1000 X--------------D-------------------C--------------W
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |    5         |         3         |         1    |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 E--------------A-------------------B--------------H
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |    6         |         4         |         2    |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 Y--------------F-------------------G--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(17, edges.Count, "Expected: edge count 17");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 300, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 700, 500, 700, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 700, 500, 700, 0), "Expected: has edge B-G"); // B-G
            Assert.IsTrue(HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assert.IsTrue(HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-E"); // A-E
            Assert.IsTrue(HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge B-H"); // B-H
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 700, 1000, 300, 1000), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-E"); // X-E
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-F"); // Y-F
            Assert.IsTrue(HasEdge(edges, 300, 0, 700, 0), "Expected: has edge F-G"); // F-G
            Assert.IsTrue(HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge G-Z"); // G-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-H"); // Z-H
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge H-W"); // H-W
        }

        [Test]
        public void FivePointsInABorderTouchingKite()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 1000), // #1
                new VoronoiSite(0, 0), // #2
                new VoronoiSite(1000, 0), // #3
                new VoronoiSite(1000, 1000), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 1-----------------------#A#-----------------------4
            //      |                     ,'   ',                     |
            //  900 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  800 |             ,·'                 '·,             |
            //      |           ,'                       ',           |
            //  700 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  600 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  500 B#                       5                       #D
            //      | ',                                           ,' |
            //  400 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  300 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  200 |             '·,                 ,·'             |
            //      |                ',             ,'                |
            //  100 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //    0 2-----------------------#C#-----------------------3
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count, "Expected: edge count 12");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 500, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 500), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 500, 1000), "Expected: has edge D-A"); // D-A
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-B"); // X-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-Z"); // D-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-A"); // Z-A
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-X"); // A-X
        }

        [Test]
        public void ThreePointsMeetingAtBorder()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 X-----------------------------------------------##B
            //      |                                          ,,·''  |
            //  900 |              1                      ,,·''       |
            //      |                                ,,·''            |
            //  800 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  700 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  600 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  500 A##                      3                        |
            //      |  ''·,,                                          |
            //  400 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  300 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  200 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  100 |              2                      ''·,,       |
            //      |                                          ''·,,  |
            //    0 Y-----------------------------------------------##C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 1000, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(100, 700), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 Y------------------------A------------------------X
            //      |                       ' '                       |
            //  900 |                     ,'   ',                     |
            //      |                    ,       ,                    |
            //  800 |                   ·         ·                   |
            //      |                  '           '                  |
            //  700 |    2           ,'             ',           1    |
            //      |               ,                 ,               |
            //  600 |              ·                   ·              |
            //      |             '                     '             |
            //  500 |           ,'           3           ',           |
            //      |          ,                           ,          |
            //  400 |         ·                             ·         |
            //      |        '                               '        |
            //  300 |      ,'                                 ',      |
            //      |     ,                                     ,     |
            //  200 |    ·                                       ·    |
            //      |   '                                         '   |
            //  100 | ,'                                           ', |
            //      |,                                               ,|
            //    0 C-------------------------------------------------B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 100), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 C##-----------------------------------------------Y
            //      |  ''·,,                                          |
            //  900 |       ''·,,                      2              |
            //      |            ''·,,                                |
            //  800 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  700 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  600 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  500 |                        3                      ##A
            //      |                                          ,,·''  |
            //  400 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  300 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  200 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  100 |       ,,·''                      1              |
            //      |  ,,·''                                          |
            //    0 B##-----------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 0, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 300), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 B-------------------------------------------------C
            //      |'                                               '|
            //  900 | ',                                           ,' |
            //      |   ,                                         ,   |
            //  800 |    ·                                       ·    |
            //      |     '                                     '     |
            //  700 |      ',                                 ,'      |
            //      |        ,                               ,        |
            //  600 |         ·                             ·         |
            //      |          '                           '          |
            //  500 |           ',           3           ,'           |
            //      |             ,                     ,             |
            //  400 |              ·                   ·              |
            //      |               '                 '               |
            //  300 |    1           ',             ,'           2    |
            //      |                  ,           ,                  |
            //  200 |                   ·         ·                   |
            //      |                    '       '                    |
            //  100 |                     ',   ,'                     |
            //      |                       , ,                       |
            //    0 X------------------------A------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count, "Expected: edge count 7");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 0, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void ThreePointsMeetingPastBorder()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 900), // #1
                new VoronoiSite(100, 100), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 X-------------------------------------##B---------W
            //      |                                ,,·''            |
            //  900 |    1                      ,,·''                 |
            //      |                      ,,·''                      |
            //  800 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  700 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  600 A''                                               |
            //      |                                                 |
            //  500 |              3                                  |
            //      |                                                 |
            //  400 D,,                                               |
            //      |  ''·,,                                          |
            //  300 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  200 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  100 |    2                      ''·,,                 |
            //      |                                ''·,,            |
            //    0 Y-------------------------------------##C---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 600, 800, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 400, 800, 0), "Expected: has edge D-C"); // D-C
            Assert.IsTrue(HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 400), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 400, 0, 0), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 800, 0), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-W"); // Z-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge W-B"); // W-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 900), // #1
                new VoronoiSite(100, 900), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 Y-------------------D---------A-------------------X
            //      |                  '           '                  |
            //  900 |    2           ,'             ',           1    |
            //      |               ,                 ,               |
            //  800 |              ·                   ·              |
            //      |             '                     '             |
            //  700 |           ,'           3           ',           |
            //      |          ,                           ,          |
            //  600 |         ·                             ·         |
            //      |        '                               '        |
            //  500 |      ,'                                 ',      |
            //      |     ,                                     ,     |
            //  400 |    ·                                       ·    |
            //      |   '                                         '   |
            //  300 | ,'                                           ', |
            //      |,                                               ,|
            //  200 C                                                 B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 1000, 1000, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 200), "Expected: has edge D-C"); // D-C
            Assert.IsTrue(HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 600, 1000, 400, 1000), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-W"); // Z-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge W-B"); // W-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 100), // #1
                new VoronoiSite(900, 900), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 Z---------C##-------------------------------------Y
            //      |            ''·,,                                |
            //  900 |                 ''·,,                      2    |
            //      |                      ''·,,                      |
            //  800 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  700 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  600 |                                               ''D
            //      |                                                 |
            //  500 |                                  3              |
            //      |                                                 |
            //  400 |                                               ,,A
            //      |                                          ,,·''  |
            //  300 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  200 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  100 |                 ,,·''                      1    |
            //      |            ,,·''                                |
            //    0 W---------B##-------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 400, 200, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 600, 200, 1000), "Expected: has edge D-C"); // D-C
            Assert.IsTrue(HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 400, 1000, 600), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-W"); // Z-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-B"); // W-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 100), // #1
                new VoronoiSite(900, 100), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B                                                 C
            //      |'                                               '|
            //  700 | ',                                           ,' |
            //      |   ,                                         ,   |
            //  600 |    ·                                       ·    |
            //      |     '                                     '     |
            //  500 |      ',                                 ,'      |
            //      |        ,                               ,        |
            //  400 |         ·                             ·         |
            //      |          '                           '          |
            //  300 |           ',           3           ,'           |
            //      |             ,                     ,             |
            //  200 |              ·                   ·              |
            //      |               '                 '               |
            //  100 |    1           ',             ,'           2    |
            //      |                  ,           ,                  |
            //    0 X-------------------A---------D-------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 400, 0, 0, 800), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 800), "Expected: has edge D-C"); // D-C
            Assert.IsTrue(HasEdge(edges, 0, 800, 0, 0), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 400, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 400, 0, 600, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge Y-C"); // Y-C
            Assert.IsTrue(HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-W"); // Z-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge W-B"); // W-B
        }

        [Test]
        public void ThreePointsMeetingAtBorderSharply()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 600), // #1
                new VoronoiSite(400, 900), // #2
                new VoronoiSite(400, 300), // #3
            };

            // 1200 X-----------------------------------------------------------Z
            //      |                                                           |
            // 1100 |                                                           |
            //      |                                                           |
            // 1000 |                                                        ,,,C
            //      |                                                ,,,··'''   |
            //  900 |                   2                     ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  800 |                          ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  700 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  600 A###                     1                                  |
            //      |   '''··,,,                                                |
            //  500 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  400 |                          '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  300 |                   3                     '''·,,,           |
            //      |                                                '''··,,,   |
            //  200 |                                                        '''B
            //      |                                                           |
            //  100 |                                                           |
            //      |                                                           |
            //    0 Y-----------------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 600, 1200, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 600, 1200, 200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 600), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 200), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 1200, 200, 1200, 1000), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1200, 1000, 1200, 1200), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 700), // #1
                new VoronoiSite(900, 800), // #2
                new VoronoiSite(300, 800), // #3
            };

            // 1200 Y-----------------------------A-----------------------------X
            //      |                            · ·                            |
            // 1100 |                           ·   ·                           |
            //      |                          ·     ·                          |
            // 1000 |                          ·     ·                          |
            //      |                         ·       ·                         |
            //  900 |                        ·         ·                        |
            //      |                       ·           ·                       |
            //  800 |              3       ·             ·       2              |
            //      |                     ·               ·                     |
            //  700 |                     ·       1       ·                     |
            //      |                    ·                 ·                    |
            //  600 |                   ·                   ·                   |
            //      |                  ·                     ·                  |
            //  500 |                 ·                       ·                 |
            //      |                ·                         ·                |
            //  400 |                ·                         ·                |
            //      |               ·                           ·               |
            //  300 |              ·                             ·              |
            //      |             ·                               ·             |
            //  200 |            ·                                 ·            |
            //      |           ·                                   ·           |
            //  100 |           ·                                   ·           |
            //      |          ·                                     ·          |
            //    0 W---------B---------------------------------------C---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 1200, 1000, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 1200, 200, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 600, 1200), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 600, 1200, 0, 1200), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1200, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 600), // #1
                new VoronoiSite(800, 300), // #2
                new VoronoiSite(800, 900), // #3
            };

            // 1200 W-----------------------------------------------------------Y
            //      |                                                           |
            // 1100 |                                                           |
            //      |                                                           |
            // 1000 B,,,                                                        |
            //      |   '''··,,,                                                |
            //  900 |           '''·,,,                     3                   |
            //      |                  '''··,,,                                 |
            //  800 |                          '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  700 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  600 |                                  1                     ###A
            //      |                                                ,,,··'''   |
            //  500 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  400 |                          ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  300 |           ,,,·'''                     2                   |
            //      |   ,,,··'''                                                |
            //  200 C'''                                                        |
            //      |                                                           |
            //  100 |                                                           |
            //      |                                                           |
            //    0 Z-----------------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1200, 600, 0, 200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 1200, 600, 0, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 600), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1200, 600, 1200, 1200), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 1000), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Z-X"); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 500), // #1
                new VoronoiSite(300, 400), // #2
                new VoronoiSite(900, 400), // #3
            };

            // 1200 Z---------C---------------------------------------B---------W
            //      |          ·                                     ·          |
            // 1100 |           ·                                   ·           |
            //      |           ·                                   ·           |
            // 1000 |            ·                                 ·            |
            //      |             ·                               ·             |
            //  900 |              ·                             ·              |
            //      |               ·                           ·               |
            //  800 |                ·                         ·                |
            //      |                ·                         ·                |
            //  700 |                 ·                       ·                 |
            //      |                  ·                     ·                  |
            //  600 |                   ·                   ·                   |
            //      |                    ·                 ·                    |
            //  500 |                     ·       1       ·                     |
            //      |                     ·               ·                     |
            //  400 |              2       ·             ·       3              |
            //      |                       ·           ·                       |
            //  300 |                        ·         ·                        |
            //      |                         ·       ·                         |
            //  200 |                          ·     ·                          |
            //      |                          ·     ·                          |
            //  100 |                           ·   ·                           |
            //      |                            · ·                            |
            //    0 X-----------------------------A-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 600, 0, 200, 1200), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 600, 0, 1000, 1200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 600, 0, 1200, 0), "Expected: has edge A-Y"); // A-Y
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 1000, 1200), "Expected: has edge W-B"); // W-B
            Assert.IsTrue(HasEdge(edges, 1000, 1200, 200, 1200), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 200, 1200, 0, 1200), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Z-X"); // Z-X
        }

        [Test]
        public void ThreePointsMeetingPastBorderSharply()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 600), // #1
                new VoronoiSite(100, 900), // #2
                new VoronoiSite(100, 300), // #3
            };

            // 1200 X-----------------------------------------------------------Z
            //      |                                                           |
            // 1100 |                                                        ,,,B
            //      |                                                ,,,··'''   |
            // 1000 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  900 |    2                     ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  800 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  700 A'''                                                        |
            //      |                                                           |
            //  600 |         1                                                 |
            //      |                                                           |
            //  500 D,,,                                                        |
            //      |   '''··,,,                                                |
            //  400 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  300 |    3                     '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  200 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  100 |                                                        '''C
            //      |                                                           |
            //    0 Y-----------------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 700, 1200, 1100), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1200, 100, 0, 500), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1200, 100, 1200, 1100), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 1200, 1100, 1200, 1200), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Z-X"); // Z-X
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 700), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 700, 0, 500), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 100), "Expected: has edge W-C"); // W-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 1000), // #1
                new VoronoiSite(900, 1100), // #2
                new VoronoiSite(300, 1100), // #3
            };

            // 1200 Y------------------------D---------A------------------------X
            //      |                       ·           ·                       |
            // 1100 |              3       ·             ·       2              |
            //      |                      ·              ·                     |
            // 1000 |                     ·       1       ·                     |
            //      |                    ·                 ·                    |
            //  900 |                   ·                   ·                   |
            //      |                  ·                     ·                  |
            //  800 |                 ·                       ·                 |
            //      |                 ·                        ·                |
            //  700 |                ·                         ·                |
            //      |               ·                           ·               |
            //  600 |              ·                             ·              |
            //      |             ·                               ·             |
            //  500 |            ·                                 ·            |
            //      |            ·                                  ·           |
            //  400 |           ·                                   ·           |
            //      |          ·                                     ·          |
            //  300 |         ·                                       ·         |
            //      |        ·                                         ·        |
            //  200 |       ·                                           ·       |
            //      |       ·                                            ·      |
            //  100 |      ·                                             ·      |
            //      |     ·                                               ·     |
            //    0 W----C-------------------------------------------------B----Z
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 700, 1200, 1100, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 100, 0, 500, 1200), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 100, 0, 1100, 0), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 1100, 0, 1200, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Z-X"); // Z-X
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 700, 1200), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 700, 1200, 500, 1200), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 500, 1200, 0, 1200), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 100, 0), "Expected: has edge W-C"); // W-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 600), // #1
                new VoronoiSite(1100, 300), // #2
                new VoronoiSite(1100, 900), // #3
            };

            // 1200 W-----------------------------------------------------------Y
            //      |                                                           |
            // 1100 C,,,                                                        |
            //      |   '''··,,,                                                |
            // 1000 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  900 |                          '''·,,,                     3    |
            //      |                                 '''··,,,                  |
            //  800 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  700 |                                                        '''D
            //      |                                                           |
            //  600 |                                                 1         |
            //      |                                                           |
            //  500 |                                                        ,,,A
            //      |                                                ,,,··'''   |
            //  400 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  300 |                          ,,,·'''                     2    |
            //      |                  ,,,··'''                                 |
            //  200 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  100 B'''                                                        |
            //      |                                                           |
            //    0 Z-----------------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1200, 500, 0, 100), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1100, 1200, 700), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 0, 1100, 0, 100), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 0, 100, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Z-X"); // Z-X
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 500), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1200, 500, 1200, 700), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 1200, 700, 1200, 1200), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 1100), "Expected: has edge W-C"); // W-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 200), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(900, 100), // #3
            };

            // 1200 Z----B-------------------------------------------------C----W
            //      |     ·                                               ·     |
            // 1100 |      ·                                             ·      |
            //      |      ·                                            ·       |
            // 1000 |       ·                                           ·       |
            //      |        ·                                         ·        |
            //  900 |         ·                                       ·         |
            //      |          ·                                     ·          |
            //  800 |           ·                                   ·           |
            //      |           ·                                  ·            |
            //  700 |            ·                                 ·            |
            //      |             ·                               ·             |
            //  600 |              ·                             ·              |
            //      |               ·                           ·               |
            //  500 |                ·                         ·                |
            //      |                ·                        ·                 |
            //  400 |                 ·                       ·                 |
            //      |                  ·                     ·                  |
            //  300 |                   ·                   ·                   |
            //      |                    ·                 ·                    |
            //  200 |                     ·       1       ·                     |
            //      |                     ·              ·                      |
            //  100 |              2       ·             ·       3              |
            //      |                       ·           ·                       |
            //    0 X------------------------A---------D------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count, "Expected: edge count 10");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 500, 0, 100, 1200), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1100, 1200, 700, 0), "Expected: has edge C-D"); // C-D
            Assert.IsTrue(HasEdge(edges, 1100, 1200, 100, 1200), "Expected: has edge C-B"); // C-B
            Assert.IsTrue(HasEdge(edges, 100, 1200, 0, 1200), "Expected: has edge B-Z"); // B-Z
            Assert.IsTrue(HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Z-X"); // Z-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 500, 0, 700, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 700, 0, 1200, 0), "Expected: has edge D-Y"); // D-Y
            Assert.IsTrue(HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Y-W"); // Y-W
            Assert.IsTrue(HasEdge(edges, 1200, 1200, 1100, 1200), "Expected: has edge W-C"); // W-C
        }

        [Test]
        public void ThreePointsMeetingAtCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 700), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(700, 100), // #3
            };

            // 1000 X########################B------------------------Z
            //      |                       '                         |
            //  900 |                     ,'                          |
            //      |                    ,                            |
            //  800 |                   ·                             |
            //      |                  '                              |
            //  700 |    1           ,'                               |
            //      |               ,                                 |
            //  600 |              ·                                  |
            //      |             '                                   |
            //  500 |           ,'           2                      ,,C
            //      |          ,                               ,,·''  |
            //  400 |         ·                           ,,·''       |
            //      |        '                       ,,·''            |
            //  300 |      ,'                   ,,·''                 |
            //      |     ,                ,,·''                      |
            //  200 |    ·            ,,·''                           |
            //      |   '        ,,·''                                |
            //  100 | ,'    ,,·''                      3              |
            //      |, ,,·''                                          |
            //    0 A##-----------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 500), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 300), // #3
            };

            // 1000 A##-----------------------------------------------X
            //      |' ''·,,                                          #
            //  900 | ',    ''·,,                      1              #
            //      |   ,        ''·,,                                #
            //  800 |    ·            ''·,,                           #
            //      |     '                ''·,,                      #
            //  700 |      ',                   ''·,,                 #
            //      |        ,                       ''·,,            #
            //  600 |         ·                           ''·,,       #
            //      |          '                               ''·,,  #
            //  500 |           ',           2                      ''B
            //      |             ,                                   |
            //  400 |              ·                                  |
            //      |               '                                 |
            //  300 |    3           ',                               |
            //      |                  ,                              |
            //  200 |                   ·                             |
            //      |                    '                            |
            //  100 |                     ',                          |
            //      |                       ,                         |
            //    0 W------------------------C------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 1000, 1000, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 1000, 500, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 300), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(300, 900), // #3
            };

            // 1000 W-----------------------------------------------##A
            //      |                                          ,,·'' '|
            //  900 |              3                      ,,·''    ,' |
            //      |                                ,,·''        ,   |
            //  800 |                           ,,·''            ·    |
            //      |                      ,,·''                '     |
            //  700 |                 ,,·''                   ,'      |
            //      |            ,,·''                       ,        |
            //  600 |       ,,·''                           ·         |
            //      |  ,,·''                               '          |
            //  500 C''                      2           ,'           |
            //      |                                   ,             |
            //  400 |                                  ·              |
            //      |                                 '               |
            //  300 |                               ,'           1    |
            //      |                              ,                  |
            //  200 |                             ·                   |
            //      |                            '                    |
            //  100 |                          ,'                     |
            //      |                         ,                       |
            //    0 Z------------------------B########################X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 500), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-X"); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 100), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(900, 700), // #3
            };

            // 1000 Z------------------------C------------------------W
            //      |                         '                       |
            //  900 |                          ',                     |
            //      |                            ,                    |
            //  800 |                             ·                   |
            //      |                              '                  |
            //  700 |                               ',           3    |
            //      |                                 ,               |
            //  600 |                                  ·              |
            //      |                                   '             |
            //  500 B,,                      2           ',           |
            //      #  ''·,,                               ,          |
            //  400 #       ''·,,                           ·         |
            //      #            ''·,,                       '        |
            //  300 #                 ''·,,                   ',      |
            //      #                      ''·,,                ,     |
            //  200 #                           ''·,,            ·    |
            //      #                                ''·,,        '   |
            //  100 #              1                      ''·,,    ', |
            //      #                                          ''·,, ,|
            //    0 X-----------------------------------------------##A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 1000, 0, 0, 500), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 1000, 0, 500, 1000), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-X"); // B-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-A"); // X-A
            Assert.IsTrue(HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge W-C"); // W-C
            Assert.IsTrue(HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assert.IsTrue(HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-B"); // Z-B
            Assert.IsTrue(HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-X"); // B-X
        }

        [Test]
        public void FourPointsMeetingAtCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 800), // #1
                new VoronoiSite(400, 700), // #2
                new VoronoiSite(700, 400), // #3
                new VoronoiSite(800, 100), // #4
            };

            //  900 X--------------C----------------------------#B
            //      |             ·                           ,' |
            //  800 |    1       ·                         ,·'   |
            //      |            ·                       ,'      |
            //  700 |           ·       2             ,·'        |
            //      |          ·                    ,'           |
            //  600 |         ·                  ,·'             |
            //      |        ·                 ,'                |
            //  500 |       ·               ,·'                  |
            //      |       ·             ,'                     |
            //  400 |      ·           ,·'             3         |
            //      |     ·          ,'                          |
            //  300 |    ·        ,·'                         ,,,D
            //      |   ·       ,'                    ,,,··'''   |
            //  200 |  ·     ,·'               ,,,·'''           |
            //      |  ·   ,'          ,,,··'''                  |
            //  100 | · ,·'     ,,,·'''                     4    |
            //      |·,',,,··'''                                 |
            //    0 A###-----------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 0, 900, 900), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 900), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 0, 900, 300), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 0, 900, 0), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 900, 0, 900, 300), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 900, 300, 900, 900), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 900, 900, 300, 900), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 300, 900, 0, 900), "Expected: has edge C-X"); // C-X
            Assert.IsTrue(HasEdge(edges, 0, 900, 0, 0), "Expected: has edge X-A"); // X-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(400, 200), // #3
                new VoronoiSite(100, 100), // #4
            };

            //  900 A###-----------------------------------------X
            //      |·','''··,,,                                 |
            //  800 | · '·,     '''·,,,                     1    |
            //      |  ·   ',          '''··,,,                  |
            //  700 |  ·     '·,               '''·,,,           |
            //      |   ·       ',                    '''··,,,   |
            //  600 |    ·        '·,                         '''C
            //      |     ·          ',                          |
            //  500 |      ·           '·,             2         |
            //      |       ·             ',                     |
            //  400 |       ·               '·,                  |
            //      |        ·                 ',                |
            //  300 |         ·                  '·,             |
            //      |          ·                    ',           |
            //  200 |           ·       3             '·,        |
            //      |            ·                       ',      |
            //  100 |    4       ·                         '·,   |
            //      |             ·                           ', |
            //    0 W--------------D----------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 0, 900, 900, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 0, 900, 900, 600), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 0, 900, 300, 0), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 0, 900, 0, 0), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 300, 0, 900, 0), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 900, 0, 900, 600), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 900, 600, 900, 900), "Expected: has edge C-X"); // C-X
            Assert.IsTrue(HasEdge(edges, 900, 900, 0, 900), "Expected: has edge X-A"); // X-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 100), // #1
                new VoronoiSite(500, 200), // #2
                new VoronoiSite(200, 500), // #3
                new VoronoiSite(100, 800), // #4
            };

            //  900 W-----------------------------------------###A
            //      |                                 ,,,··''','·|
            //  800 |    4                     ,,,·'''     ,·' · |
            //      |                  ,,,··'''          ,'   ·  |
            //  700 |           ,,,·'''               ,·'     ·  |
            //      |   ,,,··'''                    ,'       ·   |
            //  600 D'''                         ,·'        ·    |
            //      |                          ,'          ·     |
            //  500 |         3             ,·'           ·      |
            //      |                     ,'             ·       |
            //  400 |                  ,·'               ·       |
            //      |                ,'                 ·        |
            //  300 |             ,·'                  ·         |
            //      |           ,'                    ·          |
            //  200 |        ,·'             2       ·           |
            //      |      ,'                       ·            |
            //  100 |   ,·'                         ·       1    |
            //      | ,'                           ·             |
            //    0 B#----------------------------C--------------X
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 900, 900, 0, 0), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 900, 900, 600, 0), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 900, 900, 0, 600), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 900, 900, 0, 900), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 0, 900, 0, 600), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 0, 600, 0, 0), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 0, 0, 600, 0), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 600, 0, 900, 0), "Expected: has edge C-X"); // C-X
            Assert.IsTrue(HasEdge(edges, 900, 0, 900, 900), "Expected: has edge X-A"); // X-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 100), // #1
                new VoronoiSite(200, 400), // #2
                new VoronoiSite(500, 700), // #3
                new VoronoiSite(800, 800), // #4
            };

            //  900 B#----------------------------D--------------W
            //      | ',                           ·             |
            //  800 |   '·,                         ·       4    |
            //      |      ',                       ·            |
            //  700 |        '·,             3       ·           |
            //      |           ',                    ·          |
            //  600 |             '·,                  ·         |
            //      |                ',                 ·        |
            //  500 |                  '·,               ·       |
            //      |                     ',             ·       |
            //  400 |         2             '·,           ·      |
            //      |                          ',          ·     |
            //  300 C,,,                         '·,        ·    |
            //      |   '''··,,,                    ',       ·   |
            //  200 |           '''·,,,               '·,     ·  |
            //      |                  '''··,,,          ',   ·  |
            //  100 |    1                     '''·,,,     '·, · |
            //      |                                 '''··,,,',·|
            //    0 X-----------------------------------------###A
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count, "Expected: edge count 9");
            Assert.NotNull(edges);
            Assert.IsTrue(HasEdge(edges, 900, 0, 0, 900), "Expected: has edge A-B"); // A-B
            Assert.IsTrue(HasEdge(edges, 900, 0, 0, 300), "Expected: has edge A-C"); // A-C
            Assert.IsTrue(HasEdge(edges, 900, 0, 600, 900), "Expected: has edge A-D"); // A-D
            Assert.IsTrue(HasEdge(edges, 900, 0, 900, 900), "Expected: has edge A-W"); // A-W
            Assert.IsTrue(HasEdge(edges, 900, 900, 600, 900), "Expected: has edge W-D"); // W-D
            Assert.IsTrue(HasEdge(edges, 600, 900, 0, 900), "Expected: has edge D-B"); // D-B
            Assert.IsTrue(HasEdge(edges, 0, 900, 0, 300), "Expected: has edge B-C"); // B-C
            Assert.IsTrue(HasEdge(edges, 0, 300, 0, 0), "Expected: has edge C-X"); // C-X
            Assert.IsTrue(HasEdge(edges, 0, 0, 900, 0), "Expected: has edge X-A"); // X-A
        }

    }
}
