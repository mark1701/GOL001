namespace GOL
{
    class LivingCell
    {
        public LivingCell()
        {

        }

        public bool StaysAlive(int numberOfNeighbours)
        {
            return numberOfNeighbours == 2 || numberOfNeighbours == 3;
        }
    }
}
