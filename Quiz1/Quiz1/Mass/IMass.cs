namespace Quiz1.Mass
{
    /// <summary>
    /// We’re using an interface instead of an abstract class since many otherwise unrelated things have mass.
    /// </summary>
    public interface IMass
    {
        public double Mass();
    }

    internal class PlanetEarth : IMass
    {
        public double Mass()
        {
            return 5970000000000000000000000.0;
        }
    }

    internal class Butterfly : IMass
    {
        public double Mass()
        {
            return 0.00075;
        }
    }
}
