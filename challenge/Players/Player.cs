using Challenge.Shapes;

namespace Challenge.Players
{
    public abstract class Player
    {
        public string Name { get; set; }
        public abstract IShape GetShape(ShapeFactory shapeFactory);
    }
}