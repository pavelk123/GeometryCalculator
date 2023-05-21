# GeometryCalculator For Mindbox


Пример использования:
```
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRightAngled = triangle.IsRightAngled();
            var s = Geometry.GetArea(triangle);
            
            Console.WriteLine($"Площадь:{s},прямоугольный?{isRightAngled}");
    //Площадь:6,прямоугольный?True
            
            Circle circle = new Circle(3);
            s = Geometry.GetArea(circle);

            Console.WriteLine($"Площадь:{s}");
    //Площадь:28,274333882308138
            Console.ReadKey();
        }
    }
```
