using System;

class Program
{
    static void Main()
    {
        double radius = 5.0;
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"Площадь окружности с радиусом {radius} равна {area}");
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}
