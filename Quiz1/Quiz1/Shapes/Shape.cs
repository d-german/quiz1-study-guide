namespace Quiz1.Shapes
{
    /// <summary>
    /// We could have used an interface here instead of an abstract class, but we typically use interfaces for unrelated things.
    /// We can draw things that have an area and so they seem to belong together.
    /// Objects that can be drawn and have an area are likely related to each other.
    /// </summary>
    public abstract class Shape
    {
        public abstract double Area(); // using abstract since a default implementation makes little sense.
        public abstract void Draw(); // using abstract since a default implementation makes little sense.

    }
}
