using System;

namespace Least_common_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("Input a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Inpur b : ");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            bool l = false;
            while (l == false)
            { 
                if (x == y)
                {
                    Console.WriteLine("Output x : " + x);
                    l = true;
                }
                else if (x < y)
                {
                    x = x + a;
                }
                else
                    y = y + b;
            }
        }
    }
}
