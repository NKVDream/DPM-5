using System;
class Calculate
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);

    }
    public void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public void Divide(int a, int b)
    {
        if (b == 0) { Console.WriteLine("you can not divide by zero"); }
        else
        {
            Console.WriteLine(a / b);
        }
    }
    public void mul(int a, int b)
    {
        Console.WriteLine(a* b);
    }
    public void Squar(int a)
    {
        Console.WriteLine(a*a);
    }

}
