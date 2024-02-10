double value1 = 7.5;
double value2 = 3.2;
double value3 = 9.8;

if (value1 >= value2)
{
    if (value1 >= value3)
    {
        // value1 is the largest
        if (value2 >= value3)
            Console.WriteLine($"{value1}, {value2}, {value3}");
        else
            Console.WriteLine($"{value1}, {value3}, {value2}");
    }
    else
    {
        // value3 is the largest
        Console.WriteLine($"{value3}, {value1}, {value2}");
    }
}
else
{
    if (value2 >= value3)
    {
        // value2 is the largest
        if (value1 >= value3)
            Console.WriteLine($"{value2}, {value1}, {value3}");
        else
            Console.WriteLine($"{value2}, {value3}, {value1}");
    }
    else
    {
        // value3 is the largest
        Console.WriteLine($"{value3}, {value2}, {value1}");
    }
}
