using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BatTI.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            string x = "День Недели";
            switch (value)
            {
                case 1: x = "понедельник"; break;
                case 2: x = "вторник"; break;
                case 3: x = "среда"; break;
                case 4: x = "четверг"; break;
                case 5: x = "пятница"; break;
                case 6: x = "суббота"; break;
                case 7: x = "воскресенье"; break;
                default: x = "Неверное значение"; break;
            }
            return x;   
        }
    }
}
