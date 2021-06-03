using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

//2.
//а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

//3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
//Добавить свойства типа int для доступа к числителю и знаменателю;
//Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//***Добавить упрощение дробей.

namespace H_L_3
{
    struct Complex_Str
    {
        public double re;
        public double im;

        public Complex_Str Plus(Complex_Str x)
        {
            Complex_Str y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        public Complex_Str Minus(Complex_Str x)
        {
            Complex_Str y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public Complex_Str Multi(Complex_Str x)
        {
            Complex_Str y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }

        public string Print()
        {
            if (im < 0)
            {
                return re + "-" + -im + "i";
            }
            else
            {
                return re + "+" + im + "i";
            }
        }

    }

    class Complex
    {
        double re;
        double im;

        public Complex()
        {
            re = 0;
            im = 0;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re + x2.re;
            x3.im = im + x2.im;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }

        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + im * x2.re;
            return x3;
        }

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public double Im
        {
            get 
            {
                return im;
            }

            set
            {
                im = value;
            }
        }

        public string Print()
        {
            if (im < 0)
            {
                return re + "-" + -im + "i";
            }
            else
            {
                return re + "+" + im + "i";
            }
        }
    }

    class Fraction
    {
        int num;
        int den;

        public int Num
        {
            get 
            { 
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int Den
        {
            get
            {
                return den;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    den = value;
                }
            }
        }

        public double Nd
        {
            get 
            {
                return (Convert.ToDouble(num) / Convert.ToDouble(den));
            }
        }

        public Fraction()
        {
            num = 1;
            den = 1;
        }

        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();
            y.den = den * x.den;
            y.num = num * x.den + x.num * den;
            return y;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            y.den = den * x.den;
            y.num = num * x.den - x.num * den;
            return y;
        }

        public Fraction Multi(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = num * x.num;
            y.den = den * x.den;
            return y;
        }

        public Fraction Division(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = num * x.den;
            y.den = den * x.num;
            return y;
        }

        public int Ob_Den(int a, int b)
        {
            if (a == 0)
            {
                return 0;
            }
            else
            {
                if (a != b)
                {
                    do
                    {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else
                        {
                            b = b - a;
                        }
                    }
                    while (a != b);
                }
            }
            return a;
        }

        public void Simplification()
        {
            int ob_den = Ob_Den(Math.Abs(num), Math.Abs(den));

            if (ob_den != 0)
            {
                do
                {
                    num = num / ob_den;
                    den = den / ob_den;
                    ob_den = Ob_Den(Math.Abs(num), Math.Abs(den));
                }
                while ((ob_den != 1) && (ob_den != 0));
            }
        }

        public string Print()
        {
            return "(" + num + "/" + den + ")";
        }
    }

    class Program
    {
        static int SumOddPlus(List<int> t)
        {
            int count = 0;

            foreach (int item in t)
            {
                if ((item > 0) && (item % 2 == 1))
                {
                    count = count + item;
                    TabPrint(IntToStr(item));
                }
            }
            
            return count;
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
            string switcher = "0";

            TabPrint("Выберите способ:");
            TabPrint("1.Структура");
            TabPrint("2.Класс");

            do
            {
                Print("Ответ: ");
                switcher = Input();
            }
            while (!((switcher == "1") || (switcher == "2") || (switcher == "структура") || (switcher == "Структура") || (switcher == "СТРУТУРА") || (switcher == "класс") || (switcher == "Класс") || (switcher == "КЛАСС")));

            Console.Clear();

            switch (switcher)
            {
                case "1":
                case "структура":
                case "Структура":
                case "СТРУКТУРА":
                    #region //Работа структуры
                    TabPrint("Работа структуры:");
                    TabPrint("");

                    Complex_Str complex1_str;
                    complex1_str.re = 2;
                    complex1_str.im = 1;
                    Complex_Str complex2_str;
                    complex2_str.re = 1;
                    complex2_str.im = 2;
                    Complex_Str result_str;

                    Print("Сложение: ");
                    result_str = complex1_str.Plus(complex2_str);
                    Console.WriteLine("({0}) + ({1}) = ({2})", complex1_str.Print(), complex2_str.Print(), result_str.Print());

                    Print("Вычитание: ");
                    result_str = complex1_str.Minus(complex2_str);
                    Console.WriteLine("({0}) - ({1}) = ({2})", complex1_str.Print(), complex2_str.Print(), result_str.Print());

                    Print("Умножение: ");
                    result_str = complex1_str.Multi(complex2_str);
                    Console.WriteLine("({0}) * ({1}) = ({2})", complex1_str.Print(), complex2_str.Print(), result_str.Print());

                    TabPrint("");
                    Pause("Нажмите для выхода");
                    #endregion
                    break;

                case "2":
                case "класс":
                case "Класс":
                case "КЛАСС":
                    #region //Работа класса
                    Console.Clear();
                    TabPrint("Работа класса:");
                    TabPrint("");

                    Complex complex1 = new Complex(0, 0);
                    complex1.Re = 2;
                    complex1.Im = 1;
                    Complex complex2 = new Complex(0, 0);
                    complex2.Re = 1;
                    complex2.Im = 2;
                    Complex result;

                    Print("Сложение: ");
                    result = complex1.Plus(complex2);
                    Console.WriteLine("({0}) + ({1}) = ({2})", complex1.Print(), complex2.Print(), result.Print());

                    Print("Вычитание: ");
                    result = complex1.Minus(complex2);
                    Console.WriteLine("({0}) - ({1}) = ({2})", complex1.Print(), complex2.Print(), result.Print());

                    Print("Умножение: ");
                    result = complex1.Multi(complex2);
                    Console.WriteLine("({0}) * ({1}) = ({2})", complex1.Print(), complex2.Print(), result.Print());

                    TabPrint("");
                    Pause("Нажмите для выхода");
                    #endregion
                    break;

                default:
                    TabPrint("Введен неверный ответ");
                    Pause("Нажмите для выхода");
                    break;
            }
        }

        static void Task_2()
        {
            List<int> t = new List<int>();
            int n = 0;

            do
            {
                Console.Write("Введите {0}-е число: ", n + 1);
                t.Add(StrToInt(Input()));
                n++;
            }
            while (!(t[n - 1] == 0));

            Console.Clear();
            Console.WriteLine("Сумма нечетных положительных чисел: {0}", SumOddPlus(t));
            Pause("Нажмите для выхода");
        }

        static void Task_3()
        {
            Fraction fraction1 = new Fraction();
            Print("Введите числитель первой дроби: ");
            fraction1.Num = StrToInt(Input());
            Print("Введите знаменатель первой дроби: ");
            fraction1.Den = StrToInt(Input());

            Fraction fraction2 = new Fraction();
            Print("Введите числитель второй дроби: ");
            fraction2.Num = StrToInt(Input());
            Print("Введите знаменатель второй дроби: ");
            fraction2.Den = StrToInt(Input());

            Fraction result = new Fraction();

            TabPrint("");

            result = fraction1.Plus(fraction2);
            result.Simplification();
            Console.WriteLine("Сложение: {0} Десятичное представление: ({1})", result.Print(), result.Nd);
            
            result = fraction1.Minus(fraction2);
            result.Simplification();
            Console.WriteLine("Вычитание: {0} Десятичное представление: ({1})", result.Print(), result.Nd);
            
            result = fraction1.Multi(fraction2);
            result.Simplification();
            Console.WriteLine("Умножение: {0} Десятичное представление: ({1})", result.Print(), result.Nd);
            
            result = fraction1.Division(fraction2);
            result.Simplification();
            Console.WriteLine("Деление: {0} Десятичное представление: ({1})", result.Print(), result.Nd);
            
            Pause("Нажмите для выхода");
        }

        static void Main(string[] args)
        {
            int task = 0;

            Print("Задача-№: ");

            if ((Int32.TryParse(Input(), out task) == false) || ((task < 1) || (task > 3)))
            {
                do
                {
                    Print("Задача-№: ");
                }
                while ((Int32.TryParse(Input(), out task) == false) || (task < 1) || (task > 3));
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

                default:
                    TabPrint("Введен не номер задачи");
                    Pause("Нажмите для выхода");
                    break;
            }
        }
    }
}
