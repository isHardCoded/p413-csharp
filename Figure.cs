using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public abstract class Figure
    {
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    public class  Circle : Figure
    {
        private const double PI = 3.14;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea() => PI * Radius * Radius;
    }
}
