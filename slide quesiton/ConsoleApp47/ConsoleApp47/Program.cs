using System;

class VariableManipulation
{
    static void Main()
    {
        Console.WriteLine("Choose a variable type: 1 - int, 2 - double, 3 - string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter an integer: ");
                int intValue = int.Parse(Console.ReadLine());
                intValue++;
                Console.WriteLine($"Result: {intValue}");
                break;
            case 2:
                Console.Write("Enter a double: ");
                double doubleValue = double.Parse(Console.ReadLine());
                doubleValue++;
                Console.WriteLine($"Result: {doubleValue}");
                break;
            case 3:
                Console.Write("Enter a string: ");
                string stringValue = Console.ReadLine();
                stringValue += "*";
                Console.WriteLine($"Result: {stringValue}");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
