using System.Collections.Generic;
using System.Linq;

namespace GOL
{
    public class Universe
    {
        private List<Coordinate> _livingCells;

        private Universe()
        {
            _livingCells = new List<Coordinate>();
        }

        public static Universe GetEmptyUniverse() {
            return new Universe();
        }

        public bool IsEmpty() { return _livingCells.Count == 0; }

        public void SetLivingAt(Coordinate location) {
            if (!_livingCells.Any(x => x.Equals(location))) {
                _livingCells.Add(location);
            };
        }

        public void SetDeadAt(Coordinate location)
        {
            var locationToSetDead = _livingCells
                .Where(x => x.Equals(location))   
                .Single();

            _livingCells.Remove(locationToSetDead);
        }

        public void Tick() { }
    }
}
