using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        //1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        //   В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $.

        static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string f_name;
            string s_name;
            int age;
            string age_form = "лет";
            int height;
            int weight;
            string space_1 = " ";
            string space_2 = ", ";
            string space_3 = " см, ";
            string space_4 = " кг.";
            string space_5 = "Анкета: ";

            Console.Write("Введите имя: ");
            f_name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            s_name = Console.ReadLine();

            do
            {
                Console.Write("Введите возраст: ");
                age = int.Parse(Console.ReadLine());
            }
            while ((age < 1) || (age > 100));

            do
            {
                Console.Write("Введите рост(см): ");
                height = int.Parse(Console.ReadLine());
            }
            while ((height < 100) || (height > 250));

            do
            {
                Console.Write("Введите вес(кг): ");
                weight = int.Parse(Console.ReadLine());
            }
            while ((weight < 1) || (weight > 200));

            if (age % 10 == 1)
            {
                age_form = "год";
            }
            if ((age % 10 >= 2) && (age % 10 <= 4))
            {
                age_form = "года";
            }
            if ((age % 10 == 0) || ((age % 10 >= 5) && (age % 10 <= 9)))
            {
                age_form = "лет";
            }

            //Решение А

            Console.WriteLine("");
            Console.WriteLine("Анкета: " + f_name + " " + s_name + ", " + age + " " + age_form + ", " + height + " см, " + weight + " кг.");
            Console.ReadKey();

            //Решение Б

            Console.WriteLine("");
            Console.WriteLine("{10}{0}{6}{1}{7}{2}{6}{3}{7}{4}{8}{5}{9}", f_name, s_name, age, age_form, height, weight, space_1, space_2, space_3, space_4, space_5);
            Console.ReadKey();

            //Решение В

            Console.WriteLine("");
            Console.WriteLine($"{space_5}{f_name}{space_1}{s_name}{space_2}{age}{space_1}{age_form}{space_2}{height}{space_3}{weight}{space_4}");

            Pause("Нажмите для выхода");
        }
    }
}
