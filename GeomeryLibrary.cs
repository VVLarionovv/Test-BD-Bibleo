// БИБЛИОТЕКА ПО ТЗ
// В КОНЦЕ КОДА ПРИЛОЖУ SQL - Запрос по ТЗ
using System;

namespace ShapeLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}

// Запрос
// SELECT p.ProductName, COALESCE(c.CategoryName, 'Без категории') AS CategoryName
// FROM Products p
// LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
// LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
