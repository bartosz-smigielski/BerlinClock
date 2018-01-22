using BerlinClock.Interfaces;
using System;

namespace BerlinClock.Classes
{
    public class LineBuilder : ILineBuilder
    {
        private readonly int _lineLength;

        private readonly char[] _lights;

        private readonly char _defaultFilling;

        public LineBuilder(char[] lights, int lineLength, char defaultFilling)
        {
            _lineLength = lineLength;
            _lights = lights;
            _defaultFilling = defaultFilling;
        }

        public string Build(int timePart)
        {
            timePart = Math.Min(timePart, _lineLength);

            return new string(_lights, 0, timePart) + new string(_defaultFilling, _lineLength - timePart);
        }
    }
}
