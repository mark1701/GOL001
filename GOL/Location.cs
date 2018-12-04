using System;

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

        public static Coordinate GetLocation(int x, int y)
        {
            return new Coordinate(x, y);
        }

        public static Coordinate Random()
        {
            var random = new Random();
            var x = random.Next(int.MinValue, int.MaxValue);
            var y = random.Next(int.MinValue, int.MaxValue);
            return new Coordinate(x, y);
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
