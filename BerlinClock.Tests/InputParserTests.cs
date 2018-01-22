using BerlinClock.Classes;
using FluentAssertions;
using NUnit.Framework;

namespace BerlinClock.Tests
{
    [TestFixture]
    public class LinesMergerTests
    {
        private LinesMerger _linesMerger;

        [SetUp]
        public void SetUp()
        {
            _linesMerger = new LinesMerger();
        }

        [TestCase("simple line")]
        public void LinesMerger_ForOneLine_ReturnsIt(string line)
        {
            _linesMerger.Merge(new[] { line }).Should().Be(line);
        }

        [TestCase("Line one", "Line two")]
        [TestCase("aaaa", "bbbbb", "cccc")]
        public void LinesMerger_ForMultipleLines_ReturnsThemJoinedByNewLine(params string[] lines)
        {
            _linesMerger.Merge(lines).Should().Be(string.Join("\r\n",lines));
        }
    }
}
