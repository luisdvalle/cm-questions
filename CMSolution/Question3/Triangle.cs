using System;

namespace CMSolution.Question3
{
    public class Triangle
    {
        public int Side1 { get; }
        public int Side2 { get; }   
        public int Side3 { get; }
        public TriangleType Type { get; private set; }
        private delegate double Del();

        private Del _areaMethod;

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            AssignTriangleType(Side1, Side2, Side3);
        }

        public double Area()
        {
            return Math.Round(_areaMethod(), 3);
        }

        private void AssignTriangleType(int side1, int side2, int side3)
        {
            if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                _areaMethod  = AreaScalene;
                 Type = TriangleType.Scalene;
            }
            else if (side1 == side2 && side1 == side3)
            {
                _areaMethod = AreaEquilateral;
                Type = TriangleType.Equilateral;
            }
            else
            {
                _areaMethod = AreaIsosceles;
                Type = TriangleType.Isosceles;
            }
        }

        private double AreaIsosceles()
        {
            
            var semiPerimeter = (2 * Side1 + Side3) / 2F;
            return Math.Sqrt(
                semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }

        private double AreaEquilateral()
        {
            var height = Math.Sqrt(Side1 * Side1 - (Side2 / 2 * (Side2 / 2)));
            return height * Side3 / 2;
        }

        private double AreaScalene()
        {
            var semiPerimeter = (Side1 + Side2 + Side3) / 2F;
            return Math.Sqrt(
                semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }
    }
}
