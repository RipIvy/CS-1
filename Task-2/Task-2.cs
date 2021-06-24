using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        //2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h);
        //   где m — масса тела в килограммах, h — рост в метрах

        static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            double I;
            int weight;
            int height;

            do
            {
                Console.Write("Введите вес(кг): ");
                weight = int.Parse(Console.ReadLine());
            }
            while ((weight < 1) || (weight > 200));

            double m = Convert.ToDouble(weight);

            do
            {
                Console.Write("Введите рост(см): ");
                height = int.Parse(Console.ReadLine());
            }
            while ((height < 100) || (height > 250));

            double h = Convert.ToDouble(height) / 100;

            I = m / (h * h);

            Console.WriteLine("");
            Console.WriteLine("ИМТ: {0:F1}", I);

            Pause("Нажмите для выхода");
        }
    }
}
