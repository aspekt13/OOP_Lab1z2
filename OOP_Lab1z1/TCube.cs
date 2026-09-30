using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab1z1
{
    internal class TCube :TSquare
    {
        public TCube() : base()
        {
        }

        public TCube(double side) : base(side)
        {
        }

        public TCube(TCube other) : base(other)
        {
        }

        public double Volume()
        {
            return side * side * side;
        }

        public override double Area()
        {
            return 6 * side * side;
        }

        public override double Perimeter()
        {
            return 12 * side;
        }

        public override string ToString()
        {
            return $"Cube with side length: {side}, Volume: {Volume()}, Surface Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }
}
