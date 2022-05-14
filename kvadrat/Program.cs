///По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Put number a ");
int a = int.Parse(Console.ReadLine());
Console.Write("Put number b ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{   Console.WriteLine("Number a more then number b");
    if (a == b * b)
    {
        Console.WriteLine("Yes, number a=b^2");
    }
    else {
        Console.WriteLine("No, number a!=b^2");
    }
}
else
{   Console.WriteLine("Number b more then number a");
    if (b == a * a)
    {
        Console.WriteLine("Yes, number b=a^2");
    }
    else{
        Console.WriteLine("No, number b!=a^2");
    }
}