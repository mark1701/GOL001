using System;
using System.Collections.Generic;

namespace GOL
{
    public class Coordinate
    {
        private int _row;
        private int _column;
        private Cell _cell;

        private Coordinate(int x, int y)
        {
            _row = x;
            _column = y;
        }

        public static Coordinate Random()
        {
            var random = new Random();
            var x = random.Next(int.MinValue, int.MaxValue);
            var y = random.Next(int.MinValue, int.MaxValue);
            return new Coordinate(x, y);
        }

        public bool IsNeighbour(Coordinate coordinate) {
            foreach (var adjacent in Adjacents()) {
                if (coordinate.Equals(adjacent)) {
                    return true;
                }
            }
            return false;
        }

        public List<Coordinate> Adjacents() {
            var adjacentCoordinates = new List<Coordinate>();
            for (int i = -1; i <= 1; i++) {
                for (int j = -1; j <= 1; j++)
                {
                    if (i != 0 || j != 0) {
                        adjacentCoordinates.Add(new Coordinate(_row+i, _column+j));
                    }
                }
            }
            return adjacentCoordinates;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coordinate item))
            {
                return false;
            }

            return _row.Equals(item._row) && _column.Equals(item._column);
        }

    }
}
