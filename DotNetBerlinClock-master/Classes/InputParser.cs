using BerlinClock.Interfaces;
using BerlinClock.Types; 
using System.Text.RegularExpressions;

namespace BerlinClock.Classes
{
    public class InputParser : IInputParser
    {
        private Regex _timeRegex = new Regex(@"(?<Hour>\d{2}):(?<Minute>\d{2}):(?<Second>\d{2})");

        public int Parse(string input, TimePart timePart)
        {
            var match = _timeRegex.Match(input);

            return int.Parse(match.Groups[timePart.ToString()].Value);
        }
    }

}
