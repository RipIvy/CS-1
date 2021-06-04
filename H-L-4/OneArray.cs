using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OneArray
{
    public class ClassArray
    {
        int[] a;

        public ClassArray(int count, int n)
        {
            a = new int[count];
            for (int i = 0; i < count; i++)
                a[i] = n;
        }

        public ClassArray(int count, int firstElement, int step)
        {
            a = new int[count];
            a[0] = firstElement;
            for (int i = 1; i < count; i++)
                a[i] = a[i - 1] + step;
        }

        public void ArrayFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Файл не найден");
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
            }
        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        public int PlusCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int MinusCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] < 0) count++;
                return count;
            }
        }

        public string Print()
        {
            string s = "";
            foreach (int item in a)
                s = s + item + " ";
            return s;
        }

        public void SaveToFile(string filename)
        {
            StreamWriter wr = new StreamWriter(filename);
            for (int i = 0; i < a.Length; i++)
            {
                wr.WriteLine(a[i]);
            }
            wr.Close();
        }

        public void LoadFromFile(string filename)
        {

            StreamReader sr = new StreamReader(filename);
            int n = 0;
            while (sr.ReadLine() != null) { n++; }

            a = new int[n];
            sr.DiscardBufferedData();
            sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
