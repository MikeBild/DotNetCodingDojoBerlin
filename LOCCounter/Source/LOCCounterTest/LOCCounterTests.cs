using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LOCCounterCore;
using NUnit.Framework;

namespace LOCCounterTest
{
    [TestFixture]
    public class LOCCounterTests
    {
        [Test]
        public void Should_read_lines()
        {
            Assert.That(LOCCounter.Count("sampleFile.cs"), Is.EqualTo(17));   
        }
    }
}
