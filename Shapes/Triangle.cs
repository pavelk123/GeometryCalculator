using GeometryCalculator.Shapes.Interfaces;
using GeometryCalculator.Validators;

namespace GeometryCalculator.Shapes
{
    public class Triangle : IShape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            ShapeValidator.CheckValid(new double[] { side1, side2,side3 });

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double[] GetSides()
        {
            return new[] { _side1, _side2, _side3 };
        }

        public bool IsRightAngled()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}