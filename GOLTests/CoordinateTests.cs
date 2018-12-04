using NUnit.Framework;
using GOL;
using System;

namespace GOLTests
{
    [TestFixture]
    class CoordinateTests
    {

        [Test]
        public void Adjacent_Coordinates_Are_Neighbours() {
            var neighbours = 0;

            var randomCoordinate = Coordinate.Random();
            var adjacents = randomCoordinate.Adjacents();

            foreach (var adjacent in adjacents) {
                if (adjacent.IsNeighbour(randomCoordinate)) {
                    neighbours++;
                }
            }

            Assert.AreEqual(adjacents.Count, neighbours);
        }
    }
}
