using System;
using System.Diagnostics;
using AnwendungsSchicht.FizzBuzz;

namespace FizzBuzzPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new FizzBuzzer().MacheFizzBuzzVon1Bis100());
            Console.ReadLine();
        }
    }
}
