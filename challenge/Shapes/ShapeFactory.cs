using System.ComponentModel;

namespace Challenge.Shapes
{
    public class ShapeFactory
    {
        private static Rock _rockInstance;
        private static Paper _paperInstance;
        private static Scissors _scissorsInstance;
        private static Spock _spockInstance;
        private static Lizard _lizardInstance;

        public IShape GetShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.Rock:
                    return _rockInstance ?? (_rockInstance = new Rock());
                case Shape.Spock:
                    return _spockInstance ?? (_spockInstance = new Spock());
                case Shape.Paper:
                    return _paperInstance ?? (_paperInstance = new Paper());
                case Shape.Lizard:
                    return _lizardInstance ?? (_lizardInstance = new Lizard());
                case Shape.Scissors:
                    return _scissorsInstance ?? (_scissorsInstance = new Scissors());
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}