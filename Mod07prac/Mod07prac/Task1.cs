using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07prac
{
    internal class Task1
    {
        public int P1 { get; set; }
        public string P2 { get; set; }

        public Task1(int P1, string P2)
        {
            P1 = P1;
            P2 = P2;
        }

        public override bool Equals(object obj)
        {
            if (obj is Task1 other)
            {
                return P1 == other.P1 && P2 == other.P2;
            }
            return false;
        }

        public static bool operator ==(Task1 left, Task1 right)
        {
            if (left == right)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Task1 left, Task1 right)
        {
            return !(left == right);
        }
    }
}
