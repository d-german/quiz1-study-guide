namespace Quiz1.Shapes
{
    /// <summary>
    /// Violates the SRP
    ///     This class should not be responsible for creating volatile dependencies (Square).
    ///     It knows that Square needs a double for its construction.
    /// Violates the DIP
    ///     This class is depending on a concrete implementation (Square) and not only on an interface or abstract class (Shape).
    /// </summary>
    public class ShapeControllerViolations
    {
        private readonly Shape _shape = new Square(2.0);

        public void Draw()
        {
            _shape.Draw();
        }
    }

    /// <summary>
    /// Violates the DIP
    ///     This class is depending on a concrete implementation (Square) and not only on an interface or abstract class (Shape).
    /// </summary>
    public class ShapeControllerViolation
    {
        private readonly Shape _shape;

        public ShapeControllerViolation(Square shape)
        {
            _shape = shape;
        }

        public void Draw()
        {
            _shape.Draw();
        }
    }

    /// <summary>
    /// No violation
    /// </summary>
    public class ShapeController
    {
        private readonly Shape _shape;

        public ShapeController(Shape shape)
        {
            _shape = shape;
        }

        public void Draw()
        {
            _shape.Draw();
        }
    }
}
