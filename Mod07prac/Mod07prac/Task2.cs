using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07prac
{
    internal class Task2
    {
        public int[] array;
        public Task2(int[] values)
        {
            array = values;
        }
        private int GetArraySum()
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            return sum;
        }
        public static bool operator <(Task2 left, Task2 right)
        {
            if (left.GetArraySum() < right.GetArraySum()) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool operator >(Task2 left, Task2 right)
        {
            if (left.GetArraySum() > right.GetArraySum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public static Task2 operator *(Task2 left, Task2 right)
        {
            if (left.Length != right.Length)
                throw new InvalidOperationException("Массивы должны быть одинаковой длины для умножения.");

            int[] resultArray = new int[left.Length];
            for (int i = 0; i < left.Length; i++)
            {
                resultArray[i] = left[i] * right[i];
            }
            return new Task2(resultArray);
        }

        public static Task2 operator +(Task2 left, Task2 right)
        {
            if (left.Length != right.Length)
                throw new InvalidOperationException("Массивы должны быть одинаковой длины для умножения.");

            int[] resultArray = new int[left.Length];
            for (int i = 0; i < left.Length; i++)
            {
                resultArray[i] = left[i] + right[i];
            }
            return new Task2(resultArray);
        }
        public static bool operator ==(Task2 left, Task2 right)
        {
            if (left.GetArraySum() == right.GetArraySum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Task2 left, Task2 right)
        {
            return !(left == right);
        }
        public static bool operator <=(Task2 left, Task2 right)
        {
            if (left.GetArraySum() < right.GetArraySum() || left.GetArraySum() == right.GetArraySum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Task2 left, Task2 right)
        {
            if (left.GetArraySum() > right.GetArraySum() || left.GetArraySum() == right.GetArraySum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", array);
        }
    }
}
