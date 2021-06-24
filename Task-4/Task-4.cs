using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        //4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int a = 11;
            int b = 22;
            int c = 33;
            int d = -44;

            //Решение А

            Console.WriteLine("A={0}", a);
            Console.WriteLine("B={0}", b);
            Console.WriteLine("");
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("A={0}", a);
            Console.WriteLine("B={0}", b);
            Console.WriteLine("");

            //Решение Б

            Console.WriteLine("C={0}", c);
            Console.WriteLine("D={0}", d);
            Console.WriteLine("");
            c = c + d;
            d = d - c;
            d = -d;
            c = c - d;

            //q = w + q;
            //w = q - w;
            //q = q - w;
            Console.WriteLine("C={0}", c);
            Console.WriteLine("D={0}", d);
            Console.WriteLine("");

            Pause("Нажмите для выхода");
        }
    }
}
