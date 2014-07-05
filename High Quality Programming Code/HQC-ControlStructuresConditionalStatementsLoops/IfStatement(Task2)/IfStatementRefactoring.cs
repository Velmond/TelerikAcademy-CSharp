namespace IfStatementRefactoring
{
    using Cook;

    class IfStatementRefactoring
    {
        const int MinX = -100;
        const int MaxX = 100;
        const int MinY = -100;
        const int MaxY = 100;

        static void Main()
        {
            FirstSubtask();
            SecondSubtask();
        }

        private static void FirstSubtask()
        {
            Potato potato = new Potato();

            if (potato != null && (potato.IsPeeled && !potato.IsRotten))
            {
                Cook(potato);
            }
        }

        private static void Cook(Vegetable vegetable)
        {
            //... do something ...
        }

        private static void SecondSubtask()
        {
            int x = 0;
            int y = 0;
            bool isInRangeX = IsInRange(x, MinX, MaxX);
            bool isInRangeY = IsInRange(y, MinY, MaxY);
            bool shouldVisitCell = true;

            if (isInRangeX && isInRangeY && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static bool IsInRange(int coord, int bottomLimit, int topLimit)
        {
            bool isInRange = (bottomLimit <= coord && coord <= topLimit);
            return isInRange;
        }

        private static void VisitCell()
        {
            //... do something ...
        }
    }
}
