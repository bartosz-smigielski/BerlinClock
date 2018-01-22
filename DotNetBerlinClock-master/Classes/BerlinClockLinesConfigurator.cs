using System.Collections.Generic;
using BerlinClock.Interfaces;
using BerlinClock.Types;
using System.Linq;

namespace BerlinClock.Classes
{
    public class BerlinClockLinesConfigurator : IClockLinesConfiguraor
    {
        public IEnumerable<ClockLineConfiguration> ClockLinesConfiguration
        {
            get
            {
                return new[]
                {
                    new ClockLineConfiguration{ TimePart = TimePart.Second, LineLength = 1,  NormalizeFunction = t => t,   DefaultFilling =  Light.Yellow,  Lights = GetLights(1, Light.Empty)  },
                    new ClockLineConfiguration{ TimePart = TimePart.Hour,   LineLength = 4,  NormalizeFunction = t => t / 5, DefaultFilling =  Light.Empty,   Lights = GetLights(4, Light.Red) },
                    new ClockLineConfiguration{ TimePart = TimePart.Hour,   LineLength = 4,  NormalizeFunction = t => t % 5, DefaultFilling =  Light.Empty,   Lights = GetLights(4, Light.Red) },
                    new ClockLineConfiguration{ TimePart = TimePart.Minute, LineLength = 11, NormalizeFunction = t => t / 5, DefaultFilling =  Light.Empty,   Lights = GetLights(4, Light.Yellow, Light.Yellow, Light.Red) },
                    new ClockLineConfiguration{ TimePart = TimePart.Minute, LineLength = 4,  NormalizeFunction = t => t % 5, DefaultFilling =  Light.Empty,   Lights = GetLights(4, Light.Yellow)}
                };
            }
        }

        private IEnumerable<char> GetLights(int repeats, params char[] pattern)
        {
            return Enumerable.Repeat(pattern, repeats).SelectMany(l => l);
        }
    }
}
