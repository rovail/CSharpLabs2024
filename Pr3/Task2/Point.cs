using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task2
{
    public class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public Point(int x, int y, string pointName)
        {
            _x = x;
            _y = y;
            _name = pointName;
        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public string Name { get { return _name; } }
    }
}
