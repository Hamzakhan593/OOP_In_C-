using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Circle : IShapes1
    {
        private double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
