using System;
class TaskK4
{
    static void Main()
    {
       Console.WriteLine("a=");int a = int.Parse(Console.ReadLine());
       Console.WriteLine("b=");int b = int.Parse(Console.ReadLine());

        //Console.WriteLine(c);
        //Console.WriteLine(a);
        Calculate test = new Calculate();
        test.Sub(a, b);
        test.mul(a, b);
        test.Divide(a, b);
        test.Add(a, b);
        test.Squar(a);
    }
}