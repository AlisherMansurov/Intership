using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BuildLib
{
    public class House
    {
        public List<IPart> Parts = new List<IPart>();

        public IPart this[int index]
        {
            get { return Parts[index]; }
            set { Parts[index] = value; }
        }
        public void CreateADrawning ()
        {
            Parts.Add(new Basement());
            Parts.Add(new Walls());
            Parts.Add(new Walls());
            Parts.Add(new Walls());
            Parts.Add(new Walls());
            Parts.Add(new Roof());
            Parts.Add(new Door());
            Parts.Add(new Window());
            Parts.Add(new Window());
            Parts.Add(new Window());
            Parts.Add(new Window());
        }
    }
}
