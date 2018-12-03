namespace GOL
{
    class DeadCell
    {
        public DeadCell()
        {

        }

        public bool ComesToLife(int numberOfNeighbours)
        {
            return numberOfNeighbours == 3;
        }
    }
}
