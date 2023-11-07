using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class Window : IPart
    {
        public bool Ready { get; set; }=false;
        public void Build()
        {
            Console.WriteLine("Окно готово");
            Ready = true;
        }

        public void Info()
        {
            if (Ready)
            {
                Console.WriteLine("Окно построено");
            }
            else
            {
                Console.WriteLine("Окно не построено");
            }
        }
    }
}
