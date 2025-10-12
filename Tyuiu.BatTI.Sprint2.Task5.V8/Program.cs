using Tyuiu.BatTI.Sprint2.Task5.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #2                                                                *");
Console.WriteLine("* Тема: Оператор switch                                                    *");
Console.WriteLine("* Задание #5                                                               *");
Console.WriteLine("* Вариант #8                                                               *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая использует оператор switch                   *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                     *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
var res = ds.FindDateOfPreviousDay(n, m);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();