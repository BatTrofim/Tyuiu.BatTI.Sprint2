﻿using Tyuiu.BatTI.Sprint2.Task6.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #2                                                                *");
Console.WriteLine("* Тема: Получение результата из switch                                     *");
Console.WriteLine("* Задание #6                                                               *");
Console.WriteLine("* Вариант #3                                                               *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая использует оператор switch                   *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                     *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int x = Convert.ToInt32(Console.ReadLine());
var res = ds.FindDayName(x);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();
