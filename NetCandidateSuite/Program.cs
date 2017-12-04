using System;

namespace NetCandidateSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            var tri = new Triangle(Triangle.TriangleType.Equilateral);
            var circle = new Circle(0);

            Console.WriteLine(tri.GetDescription());
            Console.WriteLine(circle.GetDescription());
        }
    }
}
