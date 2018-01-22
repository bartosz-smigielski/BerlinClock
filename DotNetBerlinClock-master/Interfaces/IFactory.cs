 namespace BerlinClock.Interfaces
{
    public interface IFactory
    {
        ILineBuilder GetLineBuilder(char[] lights, char defaultFilling, int lineLength);

        IInputParser GetInputParser();

        ILinesMerger GetLinesMerger();

        IClockLinesConfiguraor GetClockLinesConfigurator();
    }
}
