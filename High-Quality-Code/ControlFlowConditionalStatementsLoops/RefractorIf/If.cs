namespace IfStatements
{
    public class IfStatementsExtract
    {
        public static void Main()
        {
            // Potato potato;
            // //... 
            // if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);

            Potato potato = null;
            //...
            bool potatoExists = true;
            bool potatoIsPeeled = true;
            bool potatoIsFresh = true;

            if (potatoExists && potatoIsPeeled && potatoIsFresh)
            {
                Cook(potato);
            }
            else
            {
                throw new ArgumentException("No food to cook. Order yourself a pizza!");
            }


            // if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            // {
            //    VisitCell();
            // }

            bool isInRangeX = MIN_X <= x && x <= MAX_X;
            bool isInRangeY = MIN_Y <= y && y <= MAX_Y;
            bool shouldVisitCell = true;

            if (isInRangeX && isInRangeY && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}