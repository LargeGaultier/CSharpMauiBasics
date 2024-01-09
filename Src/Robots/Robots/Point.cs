using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Point
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public Point()
        {
                
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
