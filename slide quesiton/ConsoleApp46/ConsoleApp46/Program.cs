using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.Write("Enter variable 1: ");
        double var1 = double.Parse(Console.ReadLine());

        Console.Write("Enter variable 2: ");
        double var2 = double.Parse(Console.ReadLine());

        Console.Write("Enter variable 3: ");
        double var3 = double.Parse(Console.ReadLine());

        Console.Write("Enter variable 4: ");
        double var4 = double.Parse(Console.ReadLine());

        Console.Write("Enter variable 5: ");
        double var5 = double.Parse(Console.ReadLine());

        double max = Math.Max(Math.Max(Math.Max(Math.Max(var1, var2), var3), var4), var5);
        Console.WriteLine($"The greatest variable is: {max}");
    }
}
