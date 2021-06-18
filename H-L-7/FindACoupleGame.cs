using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FindACoupleGame
{
    class FindACouple
    {
        List<int> data;
        int[] dataArray;
        int temp;

        Random random;

        public List<int> Data
        {
            get
            {
                return data;
            }
            private set
            {
                data = value;
            }
        }

        public int[] DataArray
        {
            get
            {
                return dataArray;
            }
            private set
            {
                dataArray = value;
            }
        }

        public int Temp
        {
            get
            {
                return temp;
            }
            private set
            {
                temp = value;
            }
        }

        public Random MyRandom
        {
            get
            {
                return random;
            }
            private set
            {
                random = value;
            }
        }

        public FindACouple()
        {
            Data = new List<int>();
            DataArray = new int[8];
            int index;
            int count = 0;
            Temp = -1;

            MyRandom = new Random();

            for (int i = 0; i < 4; i++)
            {
                Data.Add(i + 1);
                Data.Add(i + 1);
            }

            for (int i = 0; i < 8; i++)
            {
                index = MyRandom.Next(0, 8 - count);
                count++;
                DataArray[i] = Data[index];
                Data.RemoveAt(index);
            }
        }

        public void CheckCouple(int t1)
        {
            if (Temp != -1)
            {
                CheckCouple(Temp, t1);
            }
            else
            {
                Temp = t1;
            }
        }

        public void CheckCouple(int t1, int t2)
        {
            if (DataArray[t1] == DataArray[t2])
            {
                DataArray[t1] = 0;
                DataArray[t2] = 0;
            }

            Temp = -1;
        }
    }
}