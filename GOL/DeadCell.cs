namespace GOL
{
    class DeadCell
    {
        public DeadCell()
        {

        }

        public bool ComeToLife(int numberOfNeighbours)
        {
            return numberOfNeighbours == 3;
        }
    }
}
