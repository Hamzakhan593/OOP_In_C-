using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Triangle : IShapes1
    {
        private double Base;
        private double height;

        public Triangle(double @base, double Height)
        {
            Base = @base;
            Height = height;
        }

        public double CalculateArea()
        {
            return (height / Base) / 2;
        }
    }
}
