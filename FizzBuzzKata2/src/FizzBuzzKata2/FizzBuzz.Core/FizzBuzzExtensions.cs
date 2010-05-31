using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public static class FizzBuzzExtensions
    {
        public static bool IsFizz(this long source)
        {
            return source % 3 == 0; 
        }

        public static bool IsBuzz(this long source)
        {
            return source % 5 == 0;
        }

        public static bool IsFizzBuzz(this long source)
        {
            return source.IsBuzz() && source.IsFizz();        
        }
    }
}
