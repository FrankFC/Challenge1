using System;
using System.Threading;
using Challenge.Shapes;

namespace Challenge.Players
{
    public class MachinePlayer : Player
    {
        private readonly Random _rnd;

        public MachinePlayer(ShapeFactory shapeFactory) : base(shapeFactory)
        {
            Thread.Sleep(100); //to avoid generate same randoms if two machine players
            _rnd = new Random(Environment.TickCount);
        }

        public override IShape GetShape()
        {
            var options = Enum.GetValues(typeof(Shape));
            var randomShape = (Shape) options.GetValue(_rnd.Next(0, options.Length));
            return ShapeFactory.GetShape(randomShape);
        }
    }
}