namespace GOL
{
    class LivingCell : Cell
    {
        public override bool AliveInNextGeneration(int numberOfNeighbours)
        {
            return numberOfNeighbours == 2 || numberOfNeighbours == 3;
        }
    }
}
