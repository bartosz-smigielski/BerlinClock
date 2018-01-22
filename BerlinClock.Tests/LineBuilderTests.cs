using BerlinClock.Classes;
using FluentAssertions;
using NUnit.Framework;

namespace BerlinClock.Tests
{
    [TestFixture]
    public class LineBuilderTests
    {
        private LineBuilder _lineBuilder;

        [SetUp]
        public void SetUp()
        {
            _lineBuilder = new LineBuilder(new[] { 'A', 'A', 'X', 'Y', 'Z' }, 5, 'D');
        }


        [TestCase(0, "DDDDD")]
        [TestCase(1, "ADDDD")]
        [TestCase(2, "AADDD")]
        [TestCase(3, "AAXDD")]
        [TestCase(4, "AAXYD")]
        [TestCase(5, "AAXYZ")]
        public void LinesBuilder_ReturnsCorrectNumberOfLitLights(int input, string correctLine)
        {
            _lineBuilder.Build(input).Should().Be(correctLine);
        }
        
  
        
    }
}
