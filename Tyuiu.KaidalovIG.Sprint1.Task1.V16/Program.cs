using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint1.Task1.V16.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа a, x, y");
            double a, x, y;
            a = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кайдалов И. Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет следующее выражение               *");
            Console.WriteLine("*  x * 5 * y + 2 * a;.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" x * 5 * y + 2 * a;");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, x, y));



            Console.ReadKey();
        }
    }
}
