using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotLinq
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public override string ToString()
        {
            return $"Robot {Name} : {Year} - {X} - {Y}";
        }
    }
}
