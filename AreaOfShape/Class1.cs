using System;

namespace AreaOfShape
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double sideA, sideB, sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public bool IsRightAngledTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public double CalculateArea()
        {
            double p = (sideA + sideB + sideC)/2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }

    public class Rectangle : IShape
    {
        private double sideA;
        private double sideB;


        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }
        public double CalculateArea()
        {
            return sideA*sideB;
        }
    }

    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
