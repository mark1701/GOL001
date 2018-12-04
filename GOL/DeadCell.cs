namespace GOL
{
    public class DeadCell: Cell
    {
        public override bool AliveInNextGeneration(int numberOfNeighbours)
        {
            return numberOfNeighbours == 3;
        }
    }
}
