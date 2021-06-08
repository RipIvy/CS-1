using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary1;
using System.IO;
using OneArray;

//1.Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

//2.Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)*Добавьте обработку ситуации отсутствия файла на диске.

//3.
//а) Дописать класс для работы с одномерным массивом. Реализовать конструктор,
//создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum,
//которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
//в) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

//4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.

//5.
//а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
//Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
//свойство, возвращающее минимальный элемент массива,
//свойство, возвращающее максимальный элемент массива,
//метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
//*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//**в) Обработать возможные исключительные ситуации при работе с файлами.

namespace H_L_4
{
    class DArray
    {
        public int[,] a;

        public DArray()
        {
            
        }

        public DArray(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rnd.Next();
        }

        public DArray(string filename)
        {
            filename = "..\\..\\" + filename;
            string[] ss = new string[0];
            try
            {
                ss = File.ReadAllLines(filename);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не существует: " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
            }

            a = new int[ss.Length, ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {
                string[] tempArray = ss[i].Split(' ');
                for (int j = 0; j < ss.Length; j++)
                {
                    a[i, j] = int.Parse(tempArray[j]);
                }
            }

        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];

                return max;
            }
        }

        public void Sum(out long sum)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
        }

        public void IndexOfMax(out string index)
        {
            index = "-1, -1";
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] == max)
                        index = i + ", " + j;
        }

        public void SumMoreThan(out long sum, int min)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > min)
                        sum += a[i, j];
                }
        }

        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];

                return min;
            }
        }

        public string[] Print()
        {
            string[] s = new string[a.GetLength(0)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                s[i] += "[ ";
                for (int j = 0; j < a.GetLength(1); j++)
                    s[i] += String.Format("{0:D10} ", a[i, j]);
                s[i] += " ]";
            }
            return s;
        }

        public void PrintDArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void SaveToFile(string filename)
        {
            filename = "..\\..\\" + filename;

            try
            {
                StreamWriter wr = new StreamWriter(filename);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        wr.Write(a[i, j] + " ");
                    wr.Write(Environment.NewLine);
                }
                wr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не существует: " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
            }
        }

        public void LoadFromFile(string filename)
        {
            filename = "..\\..\\" + filename;

            try
            {
                StreamReader sr = new StreamReader(filename);
                int n = 0;
                while (sr.ReadLine() != null) { n++; }

                a = new int[n, n];
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < n; i++)
                {
                    string[] tempArray = sr.ReadLine().Split(' ');
                    for (int j = 0; j < tempArray.Length; j++)
                    {
                        a[i, j] = int.Parse(tempArray[j]);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не существует: " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
            }


        }

    }

    static class Array20
    {
        public static int NumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        public static bool CheckFile(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                int count = 0;

                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    try
                    {
                        int a = Int32.Parse(s);
                        count++;
                    }
                    catch (Exception exc)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static int[] ArrayFromFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            int count = 0;
            List<string> list1 = new List<string>();

            while ((!sr.EndOfStream) && (count != 20))
            {
                string s = sr.ReadLine();
                Console.WriteLine("Считали строку:" + s);
                try
                {
                    int a = Int32.Parse(s);
                    count++;
                    list1.Add(ML1.IntToStr(a));
                    Console.WriteLine("[{0}]: {1}", count, a);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    count++;
                }
            }

            sr.Close();

            int[] array1 = new int[count - 1];

            for (int i = 0; i < count - 1; i++)
            {
                array1[i] = ML1.StrToInt(list1[i]);
            }

            return array1;
        }
    }

    class Program
    {
        struct Account
        {
            string login;
            string password;

            public string Login
            {
                get
                {
                    return login;
                }
                set
                {
                    login = value;
                }
            }

            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    password = value;
                }
            }

            public void LoadFromFile(string filename)
            {
                filename = "..\\..\\" + filename;
                StreamReader sr = new StreamReader(filename);

                login = sr.ReadLine();

                password = sr.ReadLine();

                sr.Close();
            }

            public bool LoginAndPassword(Account toCheck)
            {
                if (toCheck.login == "root" && toCheck.password == "GeekBrains")
                    return true;
                else
                    return false;
            }

            public string Attempt(int x)
            {
                string s = "";
                if (x % 10 == 1 && x != 11) s += " попытка";
                else
                    if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " попытки";
                else
                        if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
                return s;
            }
        }

        static int NumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        static void Task_1()
        {
            const int arrayLength = 20;
            int[] array1 = new int[arrayLength];
            Random random = new Random();

            ML1.Print("Массив: [ ");

            for (int i = 0; i < arrayLength; i++)
            {
                array1[i] = random.Next(-10000, 10001);

                if (i == arrayLength-1)
                {
                    ML1.Print(ML1.IntToStr(array1[i]));
                }
                else
                {
                    ML1.Print(ML1.IntToStr(array1[i]));
                    ML1.Print(", ");
                }
            }

            ML1.TabPrint("]");

            int result = NumberOfPairs(array1, arrayLength);

            Console.WriteLine("Количество пар: {0}", result);

            ML1.Pause("Нажмите для выхода");
        }

        static void Task_2()
        {
            const int arrayLength = 20;
            int[] array1 = new int[arrayLength];
            Random random = new Random();

            ML1.Print("Массив: [ ");

            for (int i = 0; i < arrayLength; i++)
            {
                array1[i] = random.Next(-10000, 10001);

                if (i == arrayLength - 1)
                {
                    ML1.Print(ML1.IntToStr(array1[i]));
                }
                else
                {
                    ML1.Print(ML1.IntToStr(array1[i]));
                    ML1.Print(", ");
                }
            }

            ML1.TabPrint("]");

            int result = Array20.NumberOfPairs(array1, arrayLength);

            Console.WriteLine("Количество пар: {0}", result);

            ML1.Pause("Нажмите для продолжения");
            Console.Clear();

            ML1.TabPrint("Array.txt");

            string filename = "..\\..\\Array.txt";
            bool checkfile = Array20.CheckFile(filename);

            if (checkfile)
            {
                array1 = Array20.ArrayFromFile(filename);
            }
            else
            {
                ML1.TabPrint("Файл не найден или пуст");
            }

            ML1.Pause("Нажмите для выхода");
        }

        static void Task_3()
        {
            ML1.Print("Размер массива: ");
            int size = ML1.StrToInt(ML1.Input());
            ML1.Print("Первый элемент массива: ");
            int firstElement = ML1.StrToInt(ML1.Input()); ;
            ML1.Print("Шаг для последующих элементов: ");
            int step = ML1.StrToInt(ML1.Input()); ;

            ClassArray array1 = new ClassArray(size, firstElement, step);

            Console.WriteLine("\nСоздан массив: [ " + array1.Print() + " ]\n");

            Console.WriteLine("Сумма элементов массива: " + array1.Sum);

            array1.Inverse = -1;

            Console.WriteLine("Инверсия массива: [ " + array1.Print() + " ]\n");

            Console.Write("Число, на которое умножить элементы массива: ");

            array1.Multi = ML1.StrToInt(ML1.Input());

            Console.WriteLine("Массив, умноженный на число: [ " + array1.Print() + " ]\n");

            Console.WriteLine("Максимальный элемент массива: " + array1.Max);

            Console.WriteLine("Количество максимальных элементов массива: " + array1.MaxCount);

            Console.WriteLine("");
            Console.WriteLine("\nМассив созданный загрузкой данных из файла.");

            string fileName = "..\\..\\Array.txt";
            ClassArray myArray = new ClassArray(fileName);

            Console.WriteLine("Создан массив: [ " + myArray.Print() + " ]\n");

            string fileName2 = "..\\..\\Array2.txt";

            Console.WriteLine("\nЗагружаем массив из файла методом.");

            myArray.LoadFromFile(fileName2);

            Console.WriteLine("Загружен массив: [ " + myArray.Print() + " ]\n");

            Console.WriteLine("\nСохраняем массив в файл " + fileName + " методом.");

            myArray.SaveToFile(fileName);

            ClassArray myArray2 = new ClassArray(fileName);

            Console.WriteLine("Проверка содержимого файла: [ " + myArray2.Print() + " ]\n");

            ML1.Pause("Нажмите для выхода");
        }

        static void Task_4()
        {
            int AmountOfTries = 3;

            string[] fileName = { "Attempt1.txt", "Attempt2.txt", "Attempt3.txt" };

            Account account = new Account();
            account.Login = "";
            account.Password = "";

            int i = 0;
            bool success = false;

            do
            {
                Console.WriteLine("\nЗагружаем файл: " + fileName[i]);
                account.LoadFromFile(fileName[i]);

                Console.Write("Попытка авторизации: ");

                if (account.LoginAndPassword(account))
                {
                    success = true;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина или пароля.");
                    Console.WriteLine("У Вас осталось " + AmountOfTries + account.Attempt(AmountOfTries));
                }
                i++;
            } while ((AmountOfTries > 0) && (!success));

            if (success)
            {
                ML1.TabPrint("Авторизация успешна!");
            }
            else
            {
                ML1.TabPrint("Не осталось попыток ввода!");
            }

            ML1.Pause("Нажмите для выхода");
        }

        static void Task_5()
        {
            ML1.Print("Введите количество строк массива: ");
            int size1 = ML1.StrToInt(ML1.Input());
            ML1.Print("Введите количество столбцов массива: ");
            int size2 = ML1.StrToInt(ML1.Input());


            DArray a = new DArray(size1, size2);

            Console.WriteLine("\nСоздан массив: ");

            a.PrintDArray(a.Print());

            long sum = 0;
            a.Sum(out sum);

            Console.WriteLine("Сумма элементов массива: " + sum);

            a.SumMoreThan(out sum, a.a[0, 0]);
            Console.WriteLine("Cумма элементов массива, которые больше первого элемента: " + sum);

            Console.WriteLine("Максимальный элемент массива: " + a.Max);

            Console.WriteLine("Минимальный элемент массива: " + a.Min);

            string numOfMax = "";
            a.IndexOfMax(out numOfMax);
            Console.WriteLine("Номер максимального элемента: " + numOfMax);

            ML1.TabPrint("");

            DArray b = new DArray();

            string fileName = "loadDArray.txt";
            string fileName2 = "saveDArray.txt";

            b.LoadFromFile(fileName);

            Console.WriteLine("\nЗагружаем массив из файла  " + fileName + " методом.");
            Console.WriteLine("Загружен массив: ");

            b.PrintDArray(b.Print());

            Console.WriteLine("\nСохраняем массив в файл " + fileName2 + " методом.");

            b.SaveToFile(fileName2);

            DArray с = new DArray(fileName2);

            Console.WriteLine("Проверка содержимого файла: ");

            с.PrintDArray(с.Print());

            ML1.Pause("Нажмите для выхода");
        }

        static void Main(string[] args)
        {
            int task = 0;

            ML1.Print("Задача-№: ");

            if ((Int32.TryParse(ML1.Input(), out task) == false) || ((task < 1) || (task > 7)))
            {
                do
                {
                    ML1.Print("Задача-№: ");
                }
                while ((Int32.TryParse(ML1.Input(), out task) == false) || (task < 1) || (task > 7));
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

                default:
                    ML1.TabPrint("Введен не номер задачи");
                    ML1.Pause("Нажмите для выхода");
                    break;
            }
        }
    }
}
