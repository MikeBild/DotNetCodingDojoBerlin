using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Core;

namespace FizzBuzz.FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzzer.Run().Aggregate((x, p) => x + " " + p));
            Console.ReadLine();
        }
    }
}
