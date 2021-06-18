using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UdvoitelGame
{
    class Udvoitel
    {
        int purpose;
        int current;
        int steps;
        int maxSteps;
        bool winCheck;
        bool loseCheck;

        Random random = new Random();
        Stack<int> history = new Stack<int>();

        public int Purpose
        {
            get
            {
                return purpose;
            }
            private set
            {
                purpose = value;
            }
        }

        public int Current
        {
            get
            {
                return current;
            }
            private set
            {
                current = value;
            }
        }

        public int Steps
        {
            get
            {
                return steps;
            }
            private set
            {
                steps = value;
            }
        }

        public int MaxSteps
        {
            get
            {
                return maxSteps;
            }
            private set
            {
                maxSteps = value;
            }
        }

        public bool WinCheck
        {
            get
            {
                return winCheck;
            }
            private set
            {
                winCheck = value;
            }
        }

        public bool LoseCheck
        {
            get
            {
                return loseCheck;
            }
            private set
            {
                loseCheck = value;
            }
        }

        public Udvoitel()
        {
            Purpose = random.Next(10, 101);
            Current = 1;
            Steps = 0;
            MaxSteps = MaxStepsCheck();
            WinCheck = false;
            LoseCheck = false;
            if (MaxSteps == Steps) LoseCheck = true;
            if ((MaxSteps == Steps) && (Purpose == Current)) WinCheck = true;
        }

        public Udvoitel(int min, int max)
        {
            Purpose = random.Next(min, max + 1);
            Current = 1;
            Steps = 0;
            MaxSteps = MaxStepsCheck();
            WinCheck = false;
            LoseCheck = false;
            if (MaxSteps == Steps) LoseCheck = true;
            if ((MaxSteps == Steps) && (Purpose == Current)) WinCheck = true;
        }

        public Udvoitel(int purpose)
        {
            Purpose = purpose;
            Current = 1;
            Steps = 0;
            MaxSteps = MaxStepsCheck();
            WinCheck = false;
            LoseCheck = false;
            if (MaxSteps == Steps) LoseCheck = true;
            if ((MaxSteps == Steps) && (Purpose == Current)) WinCheck = true;
        }

        public void Plus()
        {
            if ((!WinCheck) && (!LoseCheck))
            {
                history.Push(Current);
                Current++;
                Steps++;
                if ((MaxSteps == Steps) && (Purpose != Current)) LoseCheck = true;
                if ((MaxSteps == Steps) && (Purpose == Current)) WinCheck = true;
            }
        }

        public void Multi()
        {
            if ((!WinCheck) && (!LoseCheck))
            {
                history.Push(Current);
                Current *= 2;
                Steps++;
                if ((MaxSteps == Steps) && (Purpose != Current)) LoseCheck = true;
                if ((MaxSteps == Steps) && (Purpose == Current)) WinCheck = true;
            }
        }

        public void Reset()
        {
            history.Clear();
            Current = 1;
            Steps = 0;
            WinCheck = false;
            LoseCheck = false;
        }

        public void Back()
        {
            if (history.Count != 0)
            {
                Current = history.Pop();
                Steps--;
                WinCheck = false;
                LoseCheck = false;
            }
            else
            {
                history.Clear();
                Current = 1;
                Steps = 0;
                WinCheck = false;
                LoseCheck = false;
            }
        }

        public int MaxStepsCheck()
        {
            int t = Purpose;
            int result = 0;

            do
            {
                if (t % 2 == 0)
                {
                    t /= 2;
                    result++;
                }
                else
                {
                    t -= 1;
                    result++;
                }
            }
            while (t != 1);

            return result;
        }

        public string Print()
        {
            return Current.ToString();
        }
    }
}