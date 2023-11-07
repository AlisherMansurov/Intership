using BuildLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerLib
{
    public class Team
    {
        public List<IWorker> Workers = new List<IWorker>();

        public IWorker this[int index]
        {
            get { return Workers[index]; }
            set { Workers[index] = value; }
        }
        public void CreateTeam()
        {
            Workers.Add(new Worker());
            Workers.Add(new Worker());
            Workers.Add(new TeamLeader());
            Workers.Add(new Worker());
            Workers.Add(new Worker());
            Workers.Add(new Worker());
            Workers.Add(new TeamLeader());
        }
    }
}
