namespace Test.Chess
{
    public class King
    {   //я написал вам подсказок если вы смотрите на доску
        public int x;
        public int y;

        public bool Move(int newX, int newY)
        {
             return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
        }     
        // x - start
        // newX - new position
        // x - newX <= 1
    }
}
