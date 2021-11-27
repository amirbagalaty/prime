using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AmirPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter the Number to check Prime: ");
            int A = int.Parse(Console.ReadLine());
            int B = A / 2;
            for (int E = 2; E <= B; E++)
            {
                if (A % E == 0)
                {
                    Console.Write("not Prime");
                    count = 1;
                    break;
                }
            }
            if (count == 0)
                Console.Write("Prime");

            Console.ReadKey();
        }
    }
}

