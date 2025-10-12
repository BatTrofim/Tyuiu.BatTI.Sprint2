using Tyuiu.BatTI.Sprint2.Task7.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #2                                                                *");
Console.WriteLine("* Тема: Итоговый проект                                                    *");
Console.WriteLine("* Задание #7                                                               *");
Console.WriteLine("* Вариант #14                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая проверяет, находится ли точка с данными      *");
Console.WriteLine("* координатами в окружности в заштрихванной области.                     *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
var res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();
