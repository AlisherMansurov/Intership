using BuildLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerLib
{
    public interface IWorker
    {
        void Work(List<IPart> Parts);
    }
}
