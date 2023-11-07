using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildLib;

namespace WorkerLib
{
    public class Worker : IWorker
    {
        public void Work(List<IPart> Parts)
        {
            Console.WriteLine("Стройтель приступил к работе");
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i] is Basement)
                {
                    Basement basement = Parts[i] as Basement;
                    if (basement.Ready == false)
                    {
                        basement.Ready = true;
                        Parts[i] = basement;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Parts[i] is Door)
                {
                    Door door = Parts[i] as Door;
                    if (door.Ready == false)
                    {
                        door.Ready = true;
                        Parts[i] = door;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Parts[i] is Roof)
                {
                    Roof roof = Parts[i] as Roof;
                    if (roof.Ready == false)
                    {
                        roof.Ready = true;
                        Parts[i] = roof;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Parts[i] is Walls)
                {
                    Walls walls = Parts[i] as Walls;
                    if (walls.Ready == false)
                    {
                        walls.Ready = true;
                        Parts[i] = walls;
                        Parts[i+1] = walls;
                        Parts[i+2] = walls;
                        Parts[i+3] = walls;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (Parts[i] is Window)
                {
                    Window window = Parts[i] as Window;
                    if (window.Ready == false)
                    {
                        window.Ready = true;
                        Parts[i] = window;
                        Parts[i + 1] = window;
                        Parts[i + 2] = window;
                        Parts[i + 3] = window;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
