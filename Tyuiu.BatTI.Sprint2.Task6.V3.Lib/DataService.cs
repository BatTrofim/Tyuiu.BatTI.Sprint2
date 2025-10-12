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
                case 1: x = "Понедельник"; break;
                case 2: x = "Вторник"; break;
                case 3: x = "Среда"; break;
                case 4: x = "Четверг"; break;
                case 5: x = "Пятница"; break;
                case 6: x = "Суббота"; break;
                case 7: x = "Воскресенье"; break;
                default: x = "Неверное значение"; break;
            }
            return x;   
        }
    }
}
