using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BatTI.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x < 3) && (y > 3) && (y < 6)) || ((x > 2) && (y > 2) && (x < 6) && (y < 8)) || ((x == 6) && (y > 4) && (y < 12)) || ((x > 2) && (x < 7) && (y == 11)) || ((y == 12) && (x > 3) && (x < 6)) || ((x > 6) && (x < 9) && (y > 4) && (y < 8)) || ((x > 8) && (x < 13) && (y > 2) && (y < 8)) || ((x == 13) && (y > 5) && (y < 9)) || ((x > 9) && (x < 13) && (y > 7) && (y < 12)) || ((x == 10) && (y == 12)))
            {
                res =  true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
