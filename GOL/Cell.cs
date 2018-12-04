namespace GOL
{
    internal abstract class Cell
    {
        public abstract bool AliveInNextGeneration(int numberOfNeighbours);
    }
}
