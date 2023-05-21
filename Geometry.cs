using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCalculator.Shapes.Interfaces;
using GeometryCalculator.Validators;

namespace GeometryCalculator
{
    public static class Geometry
    {
        public static double GetArea(IShape shape)
        {
            return GetArea(shape.GetSides());
        }

        public static double GetArea(double[] sides)
        {
            ShapeValidator.CheckValid(sides);

            switch (sides.Length)
            {
                case 1:
                    double radius = sides[0] / (2 * Math.PI);
                    return Math.PI * Math.Pow(radius, 2);

                case 3:
                    double p = (sides[0] + sides[1] + sides[2]) / 2;
                    return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
                
                default:
                    double area = 0;
                    for (int i = 0; i < sides.Length; i++)
                    {
                        int j = (i + 1) % sides.Length;
                        area += sides[i] * sides[j];
                    }

                    return Math.Abs(area / 2);
            }
        }
    }
}
