using System;
using System.Threading;
using Challenge.Shapes;

namespace Challenge.Players
{
    public class MachinePlayer : Player
    {
        private readonly Random _rnd;

        public MachinePlayer()
        {
            Thread.Sleep(100); //to avoid generate same randoms if two machine players
            _rnd = new Random(Environment.TickCount);
        }

        public override IShape GetShape(ShapeFactory shapeFactory)
        {
            var options = Enum.GetValues(typeof(Shape));
            var randomShape = (Shape) options.GetValue(_rnd.Next(0, options.Length));
            return shapeFactory.GetShape(randomShape);
        }
    }
}