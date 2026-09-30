using OOP_Lab1z1;
using System;
namespace OOP_Lab1z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TSquare sq1 = new TSquare(5);
            Console.WriteLine($"{sq1}");

            TSquare sq2 = new TSquare(10);
            Console.WriteLine($"{sq2}");

            TSquare sqSum = sq1 + sq2;
            Console.WriteLine($"Sum of squares: {sqSum}");

            TSquare sqDiff = sq1 - sq2;
            Console.WriteLine($"Difference of squares: {sqDiff}");

            TSquare sqMul = sq1 * 2;
            Console.WriteLine($"Product of square and 2: {sqMul}");

            int cmp = sq1.CompareTo(sq2);
            if (cmp < 0)
                Console.WriteLine("sq1 is smaller than sq2");
            else if (cmp > 0)
                Console.WriteLine("sq1 is larger than sq2");
            else
                Console.WriteLine("sq1 is equal to sq2");

            TCube cube1 = new TCube(3);
            Console.WriteLine($"{cube1}");
            Console.WriteLine($"Volume of cube: {cube1.Volume()}");

        }
    }
}
