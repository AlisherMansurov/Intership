using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public interface IPart
    {
        void Build();
        void Info();

    }
    public interface IPart2
    {
        void info();
    }

}
