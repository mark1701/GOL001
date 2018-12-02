using System.Collections.Generic;

namespace GOL
{
    public class Universe
    {
        private List<Cell> _cells;

        private Universe()
        {
            _cells = new List<Cell>();
        }

        public static Universe GetEmptyUniverse() {
            return new Universe();
        }

        public bool IsEmpty() { return _cells.Count == 0; }

        public void AddCell(Cell cell) {
            _cells.Add(cell);
        }

        public void Tick() { }
    }
}
