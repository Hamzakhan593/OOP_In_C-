using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Rectangle : IShapes1
    {
        private double Width;
        private double Height;
        public Rectangle(double width, double height    )
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
