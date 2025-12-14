using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Figure
    {
        protected int width;
        protected int height;

        public int Width
        {
            get => width;
            set => width = value;
        }

        public Figure(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"Width: {width}, Height: {height}";
        }
    }
}
