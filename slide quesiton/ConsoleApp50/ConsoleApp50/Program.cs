using System;

class NumberToWords
{
    static void Main()
    {
        Console.Write("Enter a number (0-999): ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Error: Number out of range.");
            return;
        }

        string result = ConvertNumberToWords(number);
        Console.WriteLine(result);
    }

    static string ConvertNumberToWords(int number)
    {
        if (number == 0)
        {
            return "Zero";
        }

        string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] teens = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string result = "";

        if (number >= 100)
        {
            result += units[number / 100] + " Hundred";
            number %= 100;

            if (number > 0)
            {
                result += " and ";
            }
        }

        if (number >= 20)
        {
            result += tens[number / 10];
            number %= 10;

            if (number > 0)
            {
                result += " ";
            }
        }

        if (number > 0)
        {
            if (number >= 11 && number <= 19)
            {
                result += teens[number - 11];
            }
            else
            {
                result += units[number];
            }
        }

        return result;
    }
}
