int x = 8;
int y = 15;
int z = 10;

if (x >= y)
{
    if (x >= z)
        Console.WriteLine($"The biggest number is: {x}");
    else
        Console.WriteLine($"The biggest number is: {z}");
}
else
{
    if (y >= z)
        Console.WriteLine($"The biggest number is: {y}");
    else
        Console.WriteLine($"The biggest number is: {z}");
}
