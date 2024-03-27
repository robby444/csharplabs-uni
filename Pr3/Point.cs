using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Point
    {
        private int x;
        private int y;
        private string data;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Data { get { return data; } }

        public Point(int x, int y, string data)
        {
            this.x = x;
            this.y = y;
            this.data = data;
        }
    }
}
