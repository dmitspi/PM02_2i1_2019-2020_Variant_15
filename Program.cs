using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 69.99;
            var p = Math.Truncate(num);
            var t = Math.Round(num % (int)num, 2);
            Console.Write("{0} и {1}", p, t);
            Console.ReadKey();
        }
    }
}