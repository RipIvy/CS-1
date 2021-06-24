using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        //3.
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void R(double x1, double y1, double x2, double y2)
        {
            double r;
            Console.WriteLine("");
            Console.WriteLine("Методом:");
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:F2}", r);
        }

        static void Main(string[] args)
        {
            double r;
            double x1;
            double y1;
            double x2;
            double y2;

            Console.Write("Введите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            //Решение А

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками: {0:F2}", r);

            //Решение Б

            R(x1, y1, x2, y2);
            Pause("Нажмите для выхода");
        }
    }
}
