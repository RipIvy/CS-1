using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        //6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

        static void Pause(string message)   //Пауза в консоли до нажатия клавиши
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Print(string message, int x, int y) //Напечатать сообщение в определенном месте
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }

        static void WindowSize(int width, int height)   //Выставить размер окна
        {
            Console.SetWindowSize(width, height);
        }

        static void Main(string[] args)
        {

        }
    }
}
