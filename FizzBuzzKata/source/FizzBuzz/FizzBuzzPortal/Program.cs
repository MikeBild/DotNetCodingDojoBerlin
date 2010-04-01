using System;
using System.Diagnostics;
using AnwendungsSchicht.FizzBuzz;

namespace FizzBuzzPortal
{
    class Program
    {
        static void Main(string[] args)
        {

            var fb = new FizzBuzzer();

            for (int i = 0; i < 10; i++)
            {

                var t1 = new System.Threading.Thread(() =>
                {
                
                    fb.MacheFizzBuzzVon1Bis100();
                    Console.WriteLine(fb.MacheFizzBuzzVon1Bis100());

                });
                t1.Start();
            }

            
            //Console.WriteLine(new FizzBuzzer().MacheFizzBuzzVon1Bis100());
            Console.ReadLine();
        }
    }
}
