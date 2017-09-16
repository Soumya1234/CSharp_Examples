using System;

class CastExpression
{
    static void Main()
    {
        double n;
        for(n=1.0;n<=10.0; n++)
        {
            Console.WriteLine("The square root of {0} is {1}", n, Math.Sqrt(n));
            Console.WriteLine("The whole number part:" + (int)Math.Sqrt(n));
            Console.WriteLine("The fractional part:" + (Math.Sqrt(n) - (int)Math.Sqrt(n)));
            Console.WriteLine();
        }
    }
}