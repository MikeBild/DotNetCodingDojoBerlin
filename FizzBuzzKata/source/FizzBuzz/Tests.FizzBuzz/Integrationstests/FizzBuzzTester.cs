using System;
using AnwendungsSchicht.FizzBuzz;
using NUnit.Framework;

namespace Tests.FizzBuzz.Integrationstests
{
    [TestFixture]
    [Category("Integrationstests (Happy Day)")]
    public class FizzBuzzTester
    {
        [Test]
        public void Wenn_FizzBuzz_1_bis_100_sollte_ein_Ergebnis_laut_Anforderung_zurück_geben()
        {
            var sut = new FizzBuzzer();
            var actual = sut.MacheFizzBuzzVon1Bis100();
            Assert.That(actual.Substring(0,24), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8"));
        }
    }
}