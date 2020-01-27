using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, p;
            a = p = 1;
            a = a + a;
            p = p * a;
            a = a + p;
            p = p + a;
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
