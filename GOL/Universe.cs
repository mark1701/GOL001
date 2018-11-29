using System.Collections.Generic;

namespace GOL
{
    public class Universe
    {
        private List<object> _cells;

        private Universe()
        {
            _cells = new List<object>();
        }

        public static Universe GetEmptyUniverse() {
            return new Universe();
        }

        public bool IsEmpty() { return _cells.Count == 0; }

        public void AddCell(object cell) {
            _cells.Add(cell);
        }
    }
}
