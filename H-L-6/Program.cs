using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary1;
using System.IO;
using System.Globalization;
using System.Diagnostics;

//1.Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

//2.Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
//б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).

//3.Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;

//4. * *Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
//Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

namespace H_L_6
{
    public delegate double Fun1(double a, double x);
    public delegate double Fun2(double x);

    class Student
    {
        public string secondName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string secondName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.secondName = secondName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        static long FileStreamWrite(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);

            fs.Close();

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] FileStreamRead(string fileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] byteArray = new byte[fs.Length];

            for (int i = 0; i < fs.Length; i++)
                byteArray[i] = (byte)fs.ReadByte();

            fs.Close();

            stopwatch.Stop();
            Console.WriteLine("FileStream-Milliseconds:{0}", stopwatch.ElapsedMilliseconds);

            return byteArray;
        }

        static long BinaryWriter(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < size; i++)
                bw.Write((byte)0);

            fs.Close();

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        static int[] BinaryReader(string fileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int[] intArray = new int[fs.Length / 4];
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < fs.Length / 4; i++)
                intArray[i] = br.ReadInt32();

            fs.Close();

            stopwatch.Stop();
            Console.WriteLine("BinaryReader-Milliseconds:{0}", stopwatch.ElapsedMilliseconds);

            return intArray;
        }

        static long StreamWriter(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < size; i++)
                sw.Write(0);

            fs.Close();

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        static string StreamReader(string fileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string result = sr.ReadToEnd();

            fs.Close();

            stopwatch.Stop();
            Console.WriteLine("StreamReader-Milliseconds:{0}", stopwatch.ElapsedMilliseconds);

            return result;
        }

        static long BufferedStreamWrite(string fileName, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            int count = 4;
            int buffersize = (int)(size / count);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, buffersize);
            
            for (int i = 0; i < count; i++)
                bs.Write(buffer, 0, buffersize);

            fs.Close();

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] BufferedStreamRead(string fileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int count = 4;
            int buffersize = (int)(fs.Length / count);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, buffersize);
            
            for (int i = 0; i < count; i++)
                bs.Read(buffer, 0, buffersize);

            fs.Close();

            stopwatch.Stop();
            Console.WriteLine("BufferedStream-Milliseconds:{0}", stopwatch.ElapsedMilliseconds);

            return buffer;
        }

        static int AgeCompare(Student st1, Student st2)
        {
            return string.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static int CourceAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }


        public static void Table(Fun1 F, double a, double x, double t, int left, int top)
        {
            Console.SetCursorPosition(left, top);

            Console.Write("---- a -------- x -------- F -----");

            while (x <= t)
            {
                top++;
                Console.SetCursorPosition(left, top);
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }

            top++;
            Console.SetCursorPosition(left, top);

            Console.WriteLine("----------------------------------");
        }

        public static double MyFunc(double a, double b)
        {
            return a * b * b;
        }

        public static double MySin(double a, double b)
        {
            return a * Math.Sin(b);
        }

        public static void Save(string fileName, double start, double end, double step, Fun2 F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            return array;
        }

        static double Degree2(double x)
        {
            return x * x;
        }

        static double Degree3(double x)
        {
            return x * x * x;
        }

        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double Sin(double x)
        {
            return Math.Sin(x);
        }

        static void PrintResults(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- x ------- F -----");
            int i = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[i]);
                start += step;
                i++;
            }
            Console.WriteLine("--------------------------");
        }

        static void Test()
        {
            long kb = 1024;
            long mb = 1024 * kb;
            long gbyte = 1024 * mb;
            long size = mb;
            
            Console.WriteLine("Запись файлов:");
            Console.WriteLine("FileStream-Milliseconds:{0}", FileStreamWrite("1-FSdata.bin", size));
            Console.WriteLine("BinaryWriter-Milliseconds:{0}", BinaryWriter("2-BWdata.bin", size));
            Console.WriteLine("StreamWriter-Milliseconds:{0}", StreamWriter("3-SWdata.bin", size));
            Console.WriteLine("BufferedStream-Milliseconds:{0}", BufferedStreamWrite("4-BSdata.bin", size));

            Console.WriteLine("\nЧтение файлов:");
            byte[] bytesFromFileStream = FileStreamRead("1-FSdata.bin");
            int[] intFromBinaryStream = BinaryReader("2-BWdata.bin");
            string stringFromStreamReader = StreamReader("3-SWdata.bin");
            byte[] bytesFromBufferedStream = BufferedStreamRead("4-BSdata.bin");

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_1()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun1(MyFunc), -2.5, -5, 5, 0, 1);

            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun1(MySin), 2, -5, 5, 40, 1);

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_2()
        {
            List<Fun2> functions = new List<Fun2> { new Fun2(Degree2), new Fun2(Degree3), new Fun2(Sqrt), new Fun2(Sin) };

            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1) f(x)=x^2");
            Console.WriteLine("2) f(x)=x^3");
            Console.WriteLine("3) f(x)=x^1/2");
            Console.WriteLine("4) f(x)=Sin(x)");

            int userChoose;
            do
            {
                Console.Write("Вариант: ");
                userChoose = Ml.StrToInt(Ml.Input());
            }
            while ((userChoose < 1) || (userChoose > functions.Count));

            Console.Write("\nНачало отрезка: ");
            double start = Ml.StrToDoub(Ml.Input());

            Console.Write("Конец отрезка: ");
            double end = Ml.StrToDoub(Ml.Input());

            Console.Write("Величина шага:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Save("data.bin", start, end, step, functions[userChoose - 1]);
            double min = double.MaxValue;
            Console.WriteLine("\nЗначения функции: ");
            PrintResults(start, end, step, Load("data.bin", out min));
            Console.WriteLine("Минимальное значение: {0:0.00}", min);
            Ml.Pause("Нажмите для выхода");
        }

        static void Task_3()
        {
            int magistr1 = 0;
            int magistr2 = 0;

            List<Student> list = new List<Student>();

            DateTime dt = DateTime.Now;

            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();

            StreamReader sr = new StreamReader("..\\..\\students.csv");

            do
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    if (int.Parse(s[6]) == 5)
                    {
                        magistr1++;
                    }
                    else
                    {
                        if (int.Parse(s[6]) == 6)
                        {
                            magistr2++;
                        }
                    }

                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[6])))
                        {
                            cousreFrequency[int.Parse(s[6])] += 1;
                        }
                        else
                        {
                            cousreFrequency.Add(int.Parse(s[6]), 1);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    Console.WriteLine("ESC - выход");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            while (!sr.EndOfStream);
            sr.Close();

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров первого курса:{0}", magistr1);
            Console.WriteLine("Магистров второго курса:{0}", magistr2);

            Console.Write("\nКоличество студентов от 18 до 20 лет на курсах.");

            ICollection<int> keys = cousreFrequency.Keys;

            string result = string.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");

            foreach (int key in keys)
                result += string.Format("{0,-10} {1,-10:N0}\n", key, cousreFrequency[key]);

            Console.WriteLine($"\n{result}");

            list.Sort(new Comparison<Student>(AgeCompare));
            Console.WriteLine("Сортировка по возрасту: ");

            foreach (Student v in list) Console.WriteLine($"{v.firstName,-15} {v.age}");

            list.Sort(new Comparison<Student>(CourceAgeCompare));
            Console.WriteLine("\nСортировка по курсу и возрасту: ");

            foreach (Student v in list) Console.WriteLine($"Курс-{v.course,-3} {v.firstName,-15} возраст {v.age}");

            Console.Write("\nВремя выполнения:");
            Console.WriteLine(DateTime.Now - dt);

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_4()
        {
            long kb = 1024;
            long mb = 1024 * kb;
            long gbyte = 1024 * mb;
            long size = mb;

            Console.WriteLine("Запись файлов:");
            Console.WriteLine("FileStream-Milliseconds:{0}", FileStreamWrite("1-FSdata.bin", size));
            Console.WriteLine("BinaryWriter-Milliseconds:{0}", BinaryWriter("2-BWdata.bin", size));
            Console.WriteLine("StreamWriter-Milliseconds:{0}", StreamWriter("3-SWdata.bin", size));
            Console.WriteLine("BufferedStream-Milliseconds:{0}", BufferedStreamWrite("4-BSdata.bin", size));

            Console.WriteLine("\nЧтение файлов:");
            byte[] bytesFromFileStream = FileStreamRead("1-FSdata.bin");
            int[] intFromBinaryStream = BinaryReader("2-BWdata.bin");
            string stringFromStreamReader = StreamReader("3-SWdata.bin");
            byte[] bytesFromBufferedStream = BufferedStreamRead("4-BSdata.bin");

            Ml.Pause("Нажмите для выхода");
        }

        static void Main(string[] args)
        {
            int task;

            do
            {
                Ml.Print("Задача-№: ");
            }
            while ((Int32.TryParse(Ml.Input(), out task) == false) || (task < 1) || (task > 4));


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

                case 0:
                    Test();
                    break;

                default:
                    Ml.TabPrint("Введен не номер задачи");
                    Ml.Pause("Нажмите для выхода");
                    break;
            }
        }
    }
}
