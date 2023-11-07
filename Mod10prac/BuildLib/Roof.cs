using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Roof : IPart
    {
        public bool Ready { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Крыша готова");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Крыша построена");
            }
            else
            {
                Console.WriteLine("Крыша не построена");
            }
        }
    }
}
