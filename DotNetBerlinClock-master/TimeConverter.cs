using BerlinClock.Classes;
using BerlinClock.Interfaces;
using BerlinClock.Types;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IFactory _factory;

        public TimeConverter(IFactory factory)
        {
            _factory = factory;
        }

        public TimeConverter()
            : this(new Factory())
        {
        }

        public string convertTime(string aTime)
        {
            var inputParser = _factory.GetInputParser();

            return _factory.GetLinesMerger()
                .Merge(_factory.GetClockLinesConfigurator()
                    .ClockLinesConfiguration
                        .Select(c => _factory
                            .GetLineBuilder(c.Lights.ToArray(), c.DefaultFilling, c.LineLength)
                                .Build(c.NormalizeFunction(inputParser.Parse(aTime, c.TimePart)))));
        }
    }
}
