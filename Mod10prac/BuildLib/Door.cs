using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Door : IPart
    {
        public bool Ready { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Дверь готова");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Дверь построена");
            }
            else
            {
                Console.WriteLine("Дверь не построена");
            }
        }
    }
}
