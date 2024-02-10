using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit (1-9): ");
        char inputChar = Console.ReadKey().KeyChar;

        if (char.IsDigit(inputChar))
        {
            int digit = int.Parse(inputChar.ToString());

            int result;

            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    result = digit * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    result = digit * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    result = digit * 1000;
                    break;
                default:
                    Console.WriteLine("\nError: Invalid digit entered.");
                    return;
            }

            Console.WriteLine($"\nCalculated new value: {result}");
        }
        else
        {
            Console.WriteLine("\nError: Input is not a digit.");
        }
    }
}
