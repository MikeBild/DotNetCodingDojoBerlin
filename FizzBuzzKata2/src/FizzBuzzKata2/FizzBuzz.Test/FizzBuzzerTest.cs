using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FizzBuzz.Core;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class Wenn_Zahl_teilbar_durch
    {
        [Test]
        public void Drei_Soll_Fizz_Ausgegeben_Werden()
        {
            Assert.IsTrue(3L.IsFizz());
        }

        [Test]
        public void Fünf_Soll_Buzz_Ausgegeben_Werden()
        {
            Assert.IsTrue(5L.IsBuzz());
        }

        [Test]
        public void Drei_und_Fünf_soll_FizzBuzz_Ausgegeben_Werden()
        {
            Assert.IsTrue(15L.IsFizzBuzz());
            Assert.IsFalse(25L.IsFizzBuzz());
            Assert.IsFalse(19L.IsFizzBuzz());
            Assert.IsTrue(0L.IsFizzBuzz());
        }
    }
}
