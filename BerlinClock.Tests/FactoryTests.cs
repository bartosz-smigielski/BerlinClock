using BerlinClock.Classes;
using NUnit.Framework;
using FluentAssertions;

namespace BerlinClock.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        private Factory _factory;

        [SetUp]
        public void SetUp()
        {
            _factory = new Factory();
        }

        [Test]
        public void Factory_GetLineBuilder_ReturnsCorrectClass()
        {
            _factory.GetLineBuilder(new char[] { }, 'a', 1).Should().BeOfType(typeof (LineBuilder));

        }

        [Test]
        public void Factory_GetInputParser_ReturnsCorrectClass()
        {
            _factory.GetInputParser().Should().BeOfType(typeof(InputParser));

        }

        [Test]
        public void Factory_GetLinesMerger_ReturnsCorrectClass()
        {
            _factory.GetLinesMerger().Should().BeOfType(typeof(LinesMerger));

        }

        [Test]
        public void Factory_GetClockLinesConfigurator_ReturnsCorrectClass()
        {
            _factory.GetClockLinesConfigurator().Should().BeOfType(typeof(BerlinClockLinesConfigurator));

        }
    }
}
