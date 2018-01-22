using BerlinClock.Classes;
using NUnit.Framework;
using FluentAssertions;
using System.Linq;
using BerlinClock.Types;

namespace BerlinClock.Tests
{
    [TestFixture]
    public class BerlinClockLinesConfiguratorTests
    {
        private BerlinClockLinesConfigurator _configurator;

        [SetUp]
        public void SetUp()
        {
            _configurator = new BerlinClockLinesConfigurator();
        }

        [Test]
        public void BerlinClockLinesConfiguration_HasFiveLines()
        {
            _configurator.ClockLinesConfiguration.Count().Should().Be(5);
        }

        [Test]
        public void BerlinClockLinesConfiguration_FirstLineIsCorrect()
        {
            var line = _configurator.ClockLinesConfiguration.First();

            line.DefaultFilling.Should().Be(Light.Yellow);
            line.LineLength.Should().Be(1);
            line.NormalizeFunction(2).Should().Be(2);
            line.Lights.Single().Should().Be(Light.Empty);
            line.TimePart.Should().Be(TimePart.Second);
        }


        [Test]
        public void BerlinClockLinesConfiguration_SecondLineIsCorrect()
        {
            var line = _configurator.ClockLinesConfiguration.Skip(1).First();

            line.DefaultFilling.Should().Be(Light.Empty);
            line.LineLength.Should().Be(4);
            line.NormalizeFunction(4).Should().Be(0);
            line.NormalizeFunction(5).Should().Be(1);
            line.NormalizeFunction(6).Should().Be(1);
            line.Lights.Count().Should().BeGreaterOrEqualTo(4);
            line.TimePart.Should().Be(TimePart.Hour);
        }

        [Test]
        public void BerlinClockLinesConfiguration_ThirdLineIsCorrect()
        {
            var line = _configurator.ClockLinesConfiguration.Skip(2).First();

            line.DefaultFilling.Should().Be(Light.Empty);
            line.LineLength.Should().Be(4);
            line.NormalizeFunction(4).Should().Be(4);
            line.NormalizeFunction(5).Should().Be(0);
            line.NormalizeFunction(6).Should().Be(1);
            line.Lights.Count().Should().BeGreaterOrEqualTo(4);
            line.TimePart.Should().Be(TimePart.Hour);
        }

        [Test]
        public void BerlinClockLinesConfiguration_FourthLineIsCorrect()
        {
            var line = _configurator.ClockLinesConfiguration.Skip(3).First();

            line.DefaultFilling.Should().Be(Light.Empty);
            line.LineLength.Should().Be(11);
            line.NormalizeFunction(4).Should().Be(0);
            line.NormalizeFunction(5).Should().Be(1);
            line.NormalizeFunction(6).Should().Be(1);
            line.Lights.Count().Should().BeGreaterOrEqualTo(11);
            line.TimePart.Should().Be(TimePart.Minute);
        }

        [Test]
        public void BerlinClockLinesConfiguration_FifthLineIsCorrect()
        {
            var line = _configurator.ClockLinesConfiguration.Skip(4).First();

            line.DefaultFilling.Should().Be(Light.Empty);
            line.LineLength.Should().Be(4);
            line.NormalizeFunction(4).Should().Be(4);
            line.NormalizeFunction(5).Should().Be(0);
            line.NormalizeFunction(6).Should().Be(1);
            line.Lights.Count().Should().BeGreaterOrEqualTo(4);
            line.TimePart.Should().Be(TimePart.Minute);
        }
    }
}
