namespace GOL
{
    public abstract class Cell
    {
        public abstract bool AliveInNextGeneration(int numberOfNeighbours);
    }
}
