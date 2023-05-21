using GeometryCalculator.Shapes.Interfaces;
using GeometryCalculator.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Shapes
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            ShapeValidator.CheckValid(radius);

            _radius = radius;
        }

        public double[] GetSides()
        {
            double side = Math.PI * 2 * _radius;

            return new[] { side };
        }
    }
}
