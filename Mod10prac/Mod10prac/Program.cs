using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildLib;
using WorkerLib;

namespace Mod10prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House parts = new House();
            parts.CreateADrawning();

            Team team = new Team();
            team.CreateTeam();

            Worker worker = new Worker();
            TeamLeader teamLeader = new TeamLeader();

            for (int i = 0; i < 7; i++)
            {
                if (team[i] is Worker)
                {
                    worker.Work(parts.Parts);
                }
                else
                {
                    teamLeader.Work(parts.Parts);
                }
            }

            Console.WriteLine("Стройтельство дома завершено!");
            Console.WriteLine("   ____");
            Console.WriteLine("  /    \\");
            Console.WriteLine(" /      \\");
            Console.WriteLine("/--------\\");
            Console.WriteLine("|        |");
            Console.WriteLine("|  ____  |");
            Console.WriteLine("|  |  |  |");
            Console.WriteLine("|  |  |  |");
            Console.WriteLine("|  ----  |");
            Console.WriteLine("|  [][]  |");
            Console.WriteLine("|  [][]  |");
            Console.WriteLine("----------");
        }


    }
}
