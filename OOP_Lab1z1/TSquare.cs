using System;
using System.Collections.Generic;
using System.Text;

//1.Описати клас, який містять вказані поля і методи.
//Клас “Квадрат ” – TSquare
//поля  для зберігання довжини сторін;
//методи  конструктор без параметрів, конструктор з параметрами, конструктор копіювання;

// override public string ToString();
// введення / виведення даних;
// визначення площі;
// визначення периметру;
// порівняння з іншим квадратом;
// перевантаження операторів + (додавання довжин сторін), – (віднімання довжин
//сторін), * (множення сторін на деяке число).

//2. Створити клас-нащадок TCube (куб) на основі класу TSquare. Додати метод
//знаходження об’єму куба та перевизначити відповідні методи.
//3. Створити програму-клієнт для тестування.

namespace OOP_Lab1z1
{
    internal class TSquare
    {
        protected double side;

        public TSquare()
        {
            side = 0;
        }

        public TSquare(double side)
        {
            if (side <= 0)
                throw new ArgumentException("Side length cannot be negative.");
            this.side = side;
        }

        public TSquare(TSquare other)
        {
            side = other.side;
        }

        public double Side
        {
            get { return side; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Side length cannot be negative.");
                side = value;
            }
        }

        public virtual void Input()
        {
            Console.Write("Enter the length of the side: ");
            side = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine($"Length of the side: {side}");
        }

        public virtual double Area()
        {
            return side * side;
        }

        public virtual double Perimeter()
        {
            return 4 * side;
        }

        public int CompareTo(TSquare other)
        {
            if (this.side < other.side) return -1;
            if (this.side > other.side) return 1;
            return 0;
        }

        public static TSquare operator +(TSquare a, TSquare b)
        {
            return new TSquare(a.side + b.side);
        }

        public static TSquare operator -(TSquare a, TSquare b)
        {
            if (a.side - b.side <= 0)
                throw new InvalidOperationException("Resulting side length cannot be negative or zero.");
            return new TSquare(a.side - b.side);
        }

        public static TSquare operator *(TSquare a, double multiplier)
        {
            return new TSquare(a.side * multiplier);
        }

        public override string ToString()
        {
            return $"TSquare: Side = {side}, Area = {Area()}, Perimeter = {Perimeter()}";
        }
    }
}
