namespace GOL
{
    class DeadCell: Cell
    {
        public override bool AliveInNextGeneration(int numberOfNeighbours)
        {
            return numberOfNeighbours == 3;
        }
    }
}
