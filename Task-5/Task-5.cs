using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        //5.
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организовать в центре экрана.
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

        static void Print(string f_name, string s_name, string town, int left, int top)
        {
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine("Решение В");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine(f_name);
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine(s_name);
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine(town);
            Console.SetCursorPosition(left, top + 4);
            Pause("Нажмите для выхода");
        }

        static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            string f_name;
            string s_name;
            string town;

            Console.Write("Введите имя: ");
            f_name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            s_name = Console.ReadLine();
            Console.Write("Введите город проживания: ");
            town = Console.ReadLine();

            //Решение А

            Console.Clear();
            Console.WriteLine("Решение А");
            Console.WriteLine(f_name);
            Console.WriteLine(s_name);
            Console.WriteLine(town);
            Pause("Нажмите для продолжения");

            //Решение Б

            int left = 50;
            int top = 12;

            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine("Решение Б");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(f_name);
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine(s_name);
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine(town);
            Console.SetCursorPosition(left, top+4);
            Pause("Нажмите для продолжения");
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            //Решение В

            int c_f_name = 0;       //Длина имени
            int c_s_name = 0;       //Длина фамилии
            int c_town = 0;         //Длина города
            int c_pause_msg = 18;   //Длина сообщения о паузе

            foreach (char c in f_name)  //Подсчет длины имени
            {
                c_f_name++;
            }
            foreach (char c in s_name)  //Подсчет длины фамилии
            {
                c_s_name++;
            }
            foreach (char c in town)    //Подсчет длины города
            {
                c_town++;
            }
            int left_max = (120-Math.Max(Math.Max(c_f_name, c_s_name), Math.Max(c_town, c_pause_msg))); //Максимальная длина из всех выводимых строк

            do
            {
                Console.Write("Введите отступ слева(0-{0}): ", left_max);
                left = Convert.ToInt32(Console.ReadLine());
            }
            while ((left < 0) || (left > left_max));    //Защита от переноса слов при большой длине

            do
            {
                Console.Write("Введите отступ сверху(0-25): ");
                top = Convert.ToInt32(Console.ReadLine());
            }
            while ((top < 0) || (top > 25));    //Защита от вылета консоли

            Print(f_name, s_name, town, left, top); //Открываем метод
        }
    }
}
