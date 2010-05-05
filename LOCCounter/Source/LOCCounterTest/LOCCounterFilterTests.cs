using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LOCCounterCore;

namespace LOCCounterTest
{
    [TestFixture]
    public class LOCCounterFilterTests
    {
        [Test]
        public void Filter_empty_lines()
        {
            var lines = new String[] {"  ", "some line content"};
            Assert.That(lines.FilterEmptyLine().Count(), Is.EqualTo(1));
        }

        [Test]
        public void Filter_singleline_comment()
        {
            var lines = new String[] { "  ", "// jkljljk " };
            Assert.That(lines.FilterSingleLineComment().Count(), Is.EqualTo(1));
        }

        [Test]
        public void Filter_multiline_comment()
        {
            var lines = File.ReadAllLines("SampleFileMultiLineComment.cs");
            Assert.That(lines.FilterMultiLineComment().Count(), Is.EqualTo(8));
        }
    }
}
