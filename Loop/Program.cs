using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz "); // Hvegang "i" altså 1, rammer den 3..6..9..12 osv. Så siger den fizz
                }

                else if (i % 5 == 0) // hvergang "i" rammer hver femte tal altså 5..10..15..20.. så siger den buzz
                {
                    Console.WriteLine("Buzz");
                }
                else if( i % 5 == 0 && i % 3 == 0) // 
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
