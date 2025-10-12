using Tyuiu.BatTI.Sprint2.Task4.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #2                                                                *");
Console.WriteLine("* Тема: Тернарный оператор                                                 *");
Console.WriteLine("* Задание #4                                                               *");
Console.WriteLine("* Вариант #16                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции с       *");
Console.WriteLine("* использованием тернарного оператора                                      *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Введите значение переменной Х: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Значение функции = " + res);
Console.ReadKey();