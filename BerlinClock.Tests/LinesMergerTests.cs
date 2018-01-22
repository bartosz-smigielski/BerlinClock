using BerlinClock.Classes;
using FluentAssertions;
using NUnit.Framework;

namespace BerlinClock.Tests
{
    [TestFixture]
    public class InputParserTests
    {
        private InputParser _inputParser;

        [SetUp]
        public void SetUp()
        {
            _inputParser = new InputParser();
        }

        [TestCase("00:00:00", 0)]
        [TestCase("13:17:01", 13)]
        [TestCase("23:59:59", 23)]
        [TestCase("24:00:00", 24)]
        public void InputParser_ReturnsCorrectHour(string input, int result)
        {
            _inputParser.Parse(input, Types.TimePart.Hour).Should().Be(result);
        }

        [TestCase("00:00:00", 0)]
        [TestCase("13:17:01", 17)]
        [TestCase("23:59:59", 59)]
        [TestCase("24:00:00", 0)]
        public void InputParser_ReturnsCorrectMinute(string input, int result)
        {
            _inputParser.Parse(input, Types.TimePart.Minute).Should().Be(result);
        }

        [TestCase("00:00:00", 0)]
        [TestCase("13:17:01", 1)]
        [TestCase("23:59:59", 59)]
        [TestCase("24:00:00", 0)]
        public void InputParser_ReturnsCorrectSecond(string input, int result)
        {
            _inputParser.Parse(input, Types.TimePart.Second).Should().Be(result);
        }
    }
}
