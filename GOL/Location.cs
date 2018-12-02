using System;

namespace GOL
{
    public class Location
    {
        private int _row;
        private int _column;

        private Location(int x, int y)
        {
            _row = x;
            _column = y;
        }

        public static Location GetLocation(int x, int y)
        {
            return new Location(x, y);
        }

        public static Location Random()
        {
            var random = new Random();
            var x = random.Next(int.MinValue, int.MaxValue);
            var y = random.Next(int.MinValue, int.MaxValue);
            return new Location(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Location item))
            {
                return false;
            }

            return _row.Equals(item._row) && _column.Equals(item._column);
        }

        public override int GetHashCode()
        {
            var hashCode = 610291190;
            hashCode = hashCode * -1521134295 + _row.GetHashCode();
            hashCode = hashCode * -1521134295 + _column.GetHashCode();
            return hashCode;
        }
    }
}
