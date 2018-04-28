using System;
using Challenge.Shapes;

namespace Challenge.Players
{
    public class ConsoleHumanPlayer : Player
    {
        public ConsoleHumanPlayer(ShapeFactory shapeFactory) : base(shapeFactory)
        {
        }

        public override IShape GetShape()
        {
            Console.Write($"{Name}'s turn: Choose [R]ock [S]pock [P]aper [L]izard s[C]issors: ");
            var input = Console.ReadLine();
            switch (input.ToUpper())
            {
                case "R": return ShapeFactory.GetShape(Shape.Rock);
                case "S": return ShapeFactory.GetShape(Shape.Spock);
                case "P": return ShapeFactory.GetShape(Shape.Paper);
                case "L": return ShapeFactory.GetShape(Shape.Lizard);
                case "C": return ShapeFactory.GetShape(Shape.Scissors);
                default:
                    Console.WriteLine("Not valid selection!");
                    return GetShape();
            }
        }
    }
}