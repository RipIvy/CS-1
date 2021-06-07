using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyLibrary1;
using System.IO;

//1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.

//2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) ***Создать метод, который производит частотный анализ текста.
//В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
//Здесь требуется использовать класс Dictionary.

//3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например: badc являются перестановкой abcd.

//4. *Задача ЕГЭ.
//На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
//В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
//
//<Фамилия> <Имя> <оценки>, где
//<Фамилия> — строка, состоящая не более чем из 20 символов,
//<Имя> — строка, состоящая не более чем из 15 символов,
//<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
//<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
//
//Пример входной строки:
//Иванов Петр 4 5 3
//
//Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
//Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

namespace H_L_5
{
    static class Message
    {
        public static string text;
        static readonly char[] div = { ' ', ',', '.', '-', '\n', '\t', ':' };

        static Message()
        {
            text =  "Стоило только подумать о побеге, как паук, очевидно выйдя на нужную ему дистанцию, в один прыжок сократил \n" +
                    "разделяющее нас расстояние и ударил передней лапой мне по ноге. \n" +
                    "Поморщившись от боли, я мнгновенно настроился на боевой лад. \n" +
                    "Раз уж придется драться, будем побеждать. \n" +
                    "Увернувшись от очередной попытки ударить меня лапой, я подался вперед, в мыслях уже одолев паука. \n" +
                    "Повтор слов: паук, на, на, на, лапой, лапой.";
        }

        static public void PrintWords(int lenght)
        {
            string[] words = text.Split(div);

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= lenght)
                    Console.Write(word + " ");
            }
        }

        static public void DeleteWords(char ch)
        {
            string[] words = text.Split(div);

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    text.Replace(word, "");
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
        }

        static public string MaxLength()
        {
            string[] words = text.Split(div);
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            
            return maxWord;
        }

        static public StringBuilder GetString()
        {
            string[] words = text.Split(div);

            StringBuilder result = new StringBuilder();
            int max = MaxLength().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            
            return result;
        }

        static public void FreqAnalitics(string[] words, string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] textWords = text.Split(div);
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFrequency.ContainsKey(word))
                            wordFrequency[word] += 1;
                        else
                            wordFrequency.Add(word, 1);
                    }
                }
            }

            ICollection<string> keys = wordFrequency.Keys;

            string result = string.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

            foreach (string key in keys)
                result += string.Format("{0,-10} {1,-10:N0}\n",
                                   key, wordFrequency[key]);

            Console.WriteLine($"\n{result}");
        }
    }

    class Program
    {
        struct Pupil
        {
            public string sf_name;
            public double marks;
        }

        static void Sorting(ref Pupil[] pupils)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                for (int j = 0; j < pupils.Length - i - 1; j++)
                {
                    if (pupils[j].marks > pupils[j + 1].marks)
                    {
                        Pupil tmp = pupils[j + 1];
                        pupils[j + 1] = pupils[j];
                        pupils[j] = tmp;
                    }
                }
            }
        }

        static bool Check1(string s1, string s2)
        {
            return s1.Select(char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(char.ToUpper).OrderBy(x => x));
        }

        static bool Check2(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            string _s1 = s1[0].ToString();
            string _s2 = s2[0].ToString();

            for (int i = 1; i < s1.Length; i++)
                ToCorrectOrder(ref _s1, s1[i]);

            for (int i = 1; i < s2.Length; i++)
                ToCorrectOrder(ref _s2, s2[i]);

            if (_s1.Equals(_s2))
                return true;
            else
                return false;
        }

        static void ToCorrectOrder(ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }

        }

        static void Test()
        {
            string poems = "белеет парус одинокий в тумане моря голубом";
            char[] div = {' '};
            
            string[] parts = poems.Split(div);

            Console.WriteLine("Результат разбиения строки на части: ");

            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
            
            string str = String.Join(" ", parts);

            Ml.TabPrint("");
            Ml.TabPrint("Результат сборки: ");
            Ml.TabPrint(str);

            Ml.Pause("Нажмите для выхода");
        }

        static bool NonRegex(string s)
        {
            char[] check = s.ToCharArray();

            if ((s.Length >= 2) && (s.Length <=10))
            {
                if (((check[0] >= 'a') && (check[0] <= 'z')) || ((check[0] >= 'A') && (check[0] <= 'Z')))
                {
                    for (int i = 1; i < s.Length; i++)
                    {
                        if (((check[i] >= 'a') && (check[i] <= 'z')) || ((check[i] >= 'A') && (check[i] <= 'Z')) || ((check[i] >= '0') && (check[i] <= '9')))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        static bool WithRegex(string s)
        {
            Regex check = new Regex(@"[A-Za-z]{1}[0-9A-Za-z]{1,9}");

            if (check.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Task_1()
        {
            Ml.Print("Логин(2-10): ");

            string s = Ml.Input();

            Ml.TabPrint("");

            Ml.Print("Проверка логина без регулярного выражения:");

            if (NonRegex(s))
            {
                Ml.TabPrint("Логин подходит");
            }
            else
            {
                Ml.TabPrint("Логин не подходит");
            }

            Ml.Print("Проверка логина с регулярным выражением:");

            if (WithRegex(s))
            {
                Ml.TabPrint("Логин подходит");
            }
            else
            {
                Ml.TabPrint("Логин не подходит");
            }

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_2()
        {
            Console.WriteLine("Текст: \n" + Message.text);

            Ml.Print("\nСлова, которые содержат не более 5 букв:");
            Message.PrintWords(5);

            Ml.Print("\n\nУдаление слов, с буквой 'я' в конце: ");
            Message.DeleteWords('я');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово: " + Message.MaxLength());

            Console.WriteLine("\nStringBuilder: " + Message.GetString());

            Ml.TabPrint("\nЧастотный анализ текста: ");

            string[] arr = { "паук", "на", "лапой", "я" };
            Message.FreqAnalitics(arr, Message.text);

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_3()
        {
            string first = "abcdefg";
            string second = "bdcafge";

            Console.WriteLine("Проверим строки: " + first + ", и " + second);

            if (Check1(first, second) == true && Check2(first, second) == true)
                Console.WriteLine("Строки являются перестановками друг друга.");
            else
                Console.WriteLine("Строки не являются перестановками друг друга.");

            Ml.Pause("Нажмите для выхода");
        }

        static void Task_4()
        {
            int amount = 3;
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            int n = int.Parse(sr.ReadLine());
            Pupil[] a = new Pupil[n];
            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].sf_name = s[0] + " " + s[1];
                a[i].marks = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
            }
            sr.Close();

            Sorting(ref a);

            string result = string.Format("{0,-20} {1,-10}\n\n", "Ученик", "Средний балл");

            Pupil prev = a[0];

            for (int i = 0; i < amount; i++)
            {
                if (i > 0)
                {
                    if (prev.marks == a[i].marks)
                        amount++;
                    prev = a[i];
                }

                result += string.Format("{0,-20} {1,-10:F2}\n",
                                       a[i].sf_name, a[i].marks);

            }

            Console.WriteLine($"{result}");

            Ml.Pause("Нажмите для выхода");
        }

        static void Main(string[] args)
        {
            int task = 0;

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
