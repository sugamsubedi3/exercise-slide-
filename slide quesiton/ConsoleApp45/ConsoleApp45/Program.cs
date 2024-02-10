using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two real roots: {root1} and {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"One real root: {root}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}
