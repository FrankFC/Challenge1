using Challenge.Shapes;

namespace Challenge.Players
{
    public abstract class Player
    {
        public string Name { get; set; }
        protected ShapeFactory ShapeFactory;

        public abstract IShape GetShape();

        protected Player(ShapeFactory shapeFactory)
        {
            ShapeFactory = shapeFactory;
        }
    }
}