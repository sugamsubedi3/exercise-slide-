double num1 = 2.5;
double num2 = -1.5;
double num3 = 4.0;

int negativeCount = 0;

if (num1 < 0)
    negativeCount++;
if (num2 < 0)
    negativeCount++;
if (num3 < 0)
    negativeCount++;

if (negativeCount % 2 == 0)
    Console.WriteLine("The product sign is positive");
else
    Console.WriteLine("The product sign is negative");
