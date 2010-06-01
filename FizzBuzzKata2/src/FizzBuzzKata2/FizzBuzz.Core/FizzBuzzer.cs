using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public static class FizzBuzzer
    {
        public static IEnumerable<String> Run()
        {
            for (long i = 1; i <= 100; i++)
            {
                yield return i.IsFizzBuzz()
                                 ? "FizzBuzz"
                                 : i.IsBuzz()
                                       ? "Buzz"
                                       : i.IsFizz()
                                             ? "Fizz"
                                             : i.ToString();
            }            
        }
    }
}
