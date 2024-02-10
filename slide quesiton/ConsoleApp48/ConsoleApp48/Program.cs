using System;

class SubsetSumZero
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integers separated by spaces:");
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        bool foundSubset = false;

        for (int subset = 1; subset < 32; subset++)
        {
            int currentSum = 0;

            for (int bit = 0; bit < 5; bit++)
            {
                if (((subset >> bit) & 1) == 1)
                {
                    currentSum += numbers[bit];
                }
            }

            if (currentSum == 0)
            {
                foundSubset = true;
                Console.WriteLine("Subset with sum 0 found.");
                break;
            }
        }

        if (!foundSubset)
        {
            Console.WriteLine("No subset with sum 0 found.");
        }
    }
}
