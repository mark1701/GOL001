using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public class Location
    {
        private int _row;
        private int _column;

        private Location(int x, int y) {
            _row = x;
            _column = y;
        }

        public static Location GetLocation(int x, int y) {
            return new Location(x, y);
        }

        public static Location Random() {
            var random = new Random();
            var x = random.Next(int.MinValue, int.MaxValue);
            var y = random.Next(int.MinValue, int.MaxValue);
            return new Location(x, y);
        }
    }
}
