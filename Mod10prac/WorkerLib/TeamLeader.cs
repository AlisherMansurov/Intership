using BuildLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerLib
{
    public class TeamLeader : IWorker
    {
        public void Work(List<IPart> Parts)
        {
            Console.WriteLine("Бригадир формирует отчёт");
            Console.WriteLine("Отчёт: ");
            for (int i = 0; i < Parts.Count; i++) 
            {
                if (Parts[i] is Basement)
                {
                    Basement basement = Parts[i] as Basement;
                    basement.Info();
                }

                if (Parts[i] is Door)
                {
                    Door door = Parts[i] as Door;
                    door.Info();
                }

                if (Parts[i] is Roof)
                {
                    Roof roof = Parts[i] as Roof;
                    roof.Info();
                }
                if (Parts[i] is Walls)
                {
                    Walls walls = Parts[i] as Walls;
                    walls.Info();
                }
                if (Parts[i] is Window)
                {
                    Window window = Parts[i] as Window;
                    window.Info();
                }
            }
        }
    }
}
