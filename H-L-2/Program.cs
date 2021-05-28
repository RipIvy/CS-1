using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Написать метод, возвращающий минимальное из трёх чисел.

//2. Написать метод подсчета количества цифр числа.

//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

//4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

//5.
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
//набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

//6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

//7.
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace Shchepikhin_Kirill_H_L_2
{
    class Program
    {
        static long AtoB(long a, long b, long sum)
        {
            if (a <= b)
            {
                TabPrint(LongToStr(a));
                sum += a;
                a++;
                return AtoB(a, b, sum);
            }

            return sum;
        }

        static int GoodNum(string output)
        {
            int sum;
            int c = 0;
            int t;

            for (int i = 1; i < 1000000001; i++)
            {
                //TabPrint(IntToStr(i));

                sum = 0;
                t = i;

                do
                {
                    sum += (i % 10);
                    i /= 10;
                }
                while (!((i / 10) == 0));

                i = t;

                if (sum == 0)
                {
                    sum = -1;
                }

                if ((i % sum) == 0)
                {
                    c++;

                    if ((output == "ДА") | (output == "Да") | (output == "да"))
                    {
                        TabPrint(IntToStr(i));
                    }
                }
            }

            return c;
        }

        static double Imt_rev(double I1, double h)
        {
            double I2;
            double m2 = 0;

            h = h / 100;

            if (I1 < 18.5)
            {
                I2 = 18.5 - I1;
                m2 = I2 * (h * h);
            }

            if (I1 > 25)
            {
                I2 = 25 - I1;
                m2 = I2 * (h * h);
            }

            if ((I1 >= 18.5) && (I1 <= 25))
            {
                m2 = 0;
            }

            return m2;
        }

        static double Imt(double m, double h)
        {
            double I;

            h = h / 100;
            I = m / (h * h);

            return I;
        }

        static bool Login(string login, string password)
        {
            if ((login == "root") && (password == "GeekBrains"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SumOddPlus(List<int> t)
        {
            int count = 0;

            foreach (int item in t)
            {
                if ((item > 0) && (item % 2 == 1))
                {
                    count = count + item;
                }
            }
            
            return count;
        }

        static int HowMany(int t)
        {
            int count = 1;

            if (t < 0)
            {
                t = t * (-1);
            }

            if (t > 0)
            {
                do
                {
                    count++;
                    t = t / 10;
                }
                while (t > 0);
            }
            return count;
        }

        static int Min(params int[] arr1)
        {
            int min = arr1.Min();
            return min;
        }

        static string LongToStr(long t1)
        {
            string t2;
            t2 = Convert.ToString(t1);
            return t2;
        }

        static string DoubToStr(double t1)
        {
            string t2;
            t2 = Convert.ToString(t1);
            return t2;
        }

        static double StrToDoub(string t1)
        {
            double t2 = 0;
            if (Double.TryParse(t1, out t2) == false)
            {
                Print("Введено не число, повтор: ");
                t2 = StrToDoub(Input());
            }
            return t2;
        }

        static double IntToDoub(int t1)
        {
            double t2;
            t2 = Convert.ToDouble(t1);
            return t2;
        }

        static int DoubToInt(double t1)
        {
            int t2;
            t2 = Convert.ToInt32(t1);
            return t2;
        }

        static string IntToStr(int t1)
        {
            string t2;
            t2 = Convert.ToString(t1);
            return t2;
        }

        static int StrToInt(string t1)
        {
            int t2 = 0;
            if (Int32.TryParse(t1, out t2) == false)
            {
                Print("Введено не целое число, повтор: ");
                t2 = StrToInt(Input());
            }
            return t2;
        }
        
        static string Input()
        {
            string t = Console.ReadLine();
            return t;
        }

        static void TabPrint(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }

        static void Pause(string msg)
        {
            Console.Write(msg);
            Console.ReadKey();
        }

        static void Task_1()
        {
            Print("Введите первое число: ");
            int a = StrToInt(Input());
            Print("Введите второе число: ");
            int b = StrToInt(Input());
            Print("Введите третье число: ");
            int c = StrToInt(Input());
            int min = Min(a, b, c);
            TabPrint("Минимальное: "+IntToStr(min));
            Pause("Нажмите для выхода");
        }

        static void Task_2()
        {
            Print("Введите число: ");
            int t = StrToInt(Input());
            int count = HowMany(t);
            TabPrint("Цифр: "+IntToStr(count));
            Pause("Нажмите для выхода");
        }

        static void Task_3()
        {
            List<int> t = new List<int>();
            int n = 0;

            do
            {
                Console.Write("Введите {0}-е число: ", n+1);
                t.Add(StrToInt(Input()));
                n++;
            }
            while (!(t[n-1] == 0));

            Console.WriteLine("Ответ: {0}", SumOddPlus(t));
            Pause("Нажмите для выхода");
        }

        static void Task_4()
        {
            string login;
            string password;
            bool correct = false;
            int c_try = 0;

            do
            {
                if ((c_try > 0) && (!correct))
                {
                    TabPrint("Ошибка авторизации");
                    TabPrint("");
                }

                Print("Введите логин: ");
                login = Input();

                Print("Введите пароль: ");
                password = Input();

                correct = Login(login, password);

                if (!correct)
                {
                    c_try++;
                }
            }
            while ((!correct) && (c_try < 3));

            if ((!correct) && (c_try == 3))
            {
                TabPrint("Вы исчерпали попытки ввода");
            }
            else
            {
                TabPrint("Успешная авторизация");
            }
            Pause("Нажмите для выхода");
        }

        static void Task_5()
        {
            Print("Введите вес(кг): ");
            double m = StrToDoub(Input());

            Print("Введите рост(см): ");
            double h = StrToDoub(Input());

            double I = Imt(m, h);

            double m2 = Imt_rev(I, h);

            if (m2 < 0)
            {
                Console.WriteLine("Нужно похудеть на {0:F1} кг", -(m2));
            }

            if (m2 > 0)
            {
                Console.WriteLine("Нужно набрать {0:F1} кг", m2);
            }

            if (m2 == 0)
            {
                TabPrint("Вы идеальны!");
            }

            Pause("Нажмите для выхода");
        }

        static void Task_6()
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;

            Print("Выводить прогресс?(да/нет): ");
            string output = Input();
            TabPrint("Вычисляю, займет время...");
            
            int sum = GoodNum(output);

            DateTime date2 = new DateTime();
            date2 = DateTime.Now;

            TimeSpan interval = date1.Subtract(date2);

            TabPrint("Кол-во 'хороших' чисел: "+IntToStr(sum));
            Console.WriteLine("Подсчет занял {0} минут(у) {1} секунд(у)", interval.TotalMinutes, interval.TotalSeconds);
            Console.WriteLine("Подсчет занял {0} секунд(у)", interval.TotalSeconds);
            Console.WriteLine("Подсчет занял {0} милисекунд(у)", interval.TotalMilliseconds);
            Pause("Нажмите для выхода");
        }

        static void Task_7()
        {
            Print("Введите число А: ");
            long a = StrToInt(Input());

            Print("Введите число В: ");
            long b = StrToInt(Input());

            long sum = 0;

            if (b < a)
            {
                long t = a;
                a = b;
                b = t;
            }

            sum = AtoB(a, b, sum);

            Console.WriteLine("Сумма всех чисел: {0}", sum);
            Pause("Нажмите для выхода");
        }

        static void Main(string[] args)
        {
            int task = 0;
            
            Print("Задача-№: ");

            if ((Int32.TryParse(Input(), out task) == false) || ((task < 1) || (task > 7)))
            {
                do
                {
                    Print("Задача-№: ");
                }
                while ((Int32.TryParse(Input(), out task) == false) || (task < 1) || (task > 7));
            }

            Console.Clear();

            switch (task)
            {
                case 1:
                    Task_1();
                    break;

                case 2:
                    Task_2();
                    break;

                case 3:
                    Task_3();
                    break;

                case 4:
                    Task_4();
                    break;

                case 5:
                    Task_5();
                    break;

                case 6:
                    Task_6();
                    break;

                case 7:
                    Task_7();
                    break;

                default:
                    TabPrint("Введен не номер задачи");
                    Pause("Нажмите для выхода");
                    break;
            }
        }
    }
}
