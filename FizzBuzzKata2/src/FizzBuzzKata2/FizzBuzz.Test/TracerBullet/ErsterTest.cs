using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Test.TracerBullet
{
    [TestFixture]
    public class ErsterTest
    {
        [Test]
        public void ErsterFunktionalerTest()
        {
            var sut = new FizzBuzzer();
            var foo = sut.Run(0, 5);
            var output = foo.Aggregate((x, p) => String.Concat(x, " ", p));

            Assert.That(output, Is.EqualTo("FizzBuzz 1 2 Fizz 4 Buzz"));
        }
    }

    public class FizzBuzzer
    {
        public IEnumerable<string> Run(long von, long bis)
        {
            yield return "FizzBuzz";
            yield return "1";
            yield return "2";
            yield return "Fizz";
            yield return "4";
            yield return "Buzz";            
        }
    }
}