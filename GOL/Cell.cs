namespace GOL
{
    class Cell
    {
        private bool _alive;
        private int _numberOfNeighbours;
        private bool _stableNeighbourhood => _numberOfNeighbours == 2 || _numberOfNeighbours == 3;
        private bool _fertileNeighbourhood => _numberOfNeighbours == 3;

        public Cell()
        {

        }

        public bool AliveInNextGeneration()
        {
            return (_alive && _stableNeighbourhood) || _fertileNeighbourhood;
        }


    }
}
