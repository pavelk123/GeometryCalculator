using GeometryCalculator.Shapes.Interfaces;

namespace GeometryCalculator.Validators
{
    public static class ShapeValidator
    {
        public static void CheckValid(IShape shape)
        {
            var sides = shape.GetSides();

            CheckValid(sides);
        }

        public static void CheckValid(double[] sides)
        {
            if (sides.Length == 2)
            {
                throw new ArgumentException($"Пепеданно неверное количесво сторон({sides.Length})");
            }

            foreach (var side in sides)
            {
                CheckValid(side);
            }
        }

        public static void CheckValid(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Преданное значение не может быть отрицательным");
        }
    }
}
