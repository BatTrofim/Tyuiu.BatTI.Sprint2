using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BatTI.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool z = new bool();
            if (x > 0)
            {
                z = true;
            }
            else if ((y > 0) && (Math.Abs(y) > Math.Abs(x)))
            {
                z = true;      
            }
            else
            {
                z = false;
            }
            return z;
        }
    }
}
