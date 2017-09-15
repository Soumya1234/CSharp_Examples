using System;

class CastDemo
{
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;

        x = 10.0;
        y = 3.0;

        /* Casting a double into int, fractional component lost */
        i = (int)(x / y);
        Console.WriteLine("Value of i is:" + i);
        Console.WriteLine();

        /* Cast an int into byte, no data loss */
        i = 255;
        b = (byte)i;
        Console.WriteLine("b after assigning 255:" + b);
        Console.WriteLine();

        /* Cast an int into byte, data lost */
        i = 257;
        b = (byte)i;
        Console.WriteLine("b after assigning 257:" + b);
        Console.WriteLine();

        /* Cast an int into char */
        i = 88;
        ch = (char)i;
        Console.WriteLine("ch after passing 88:" + ch);

    }
}