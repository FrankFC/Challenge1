using System;
using Challenge.Shapes;

namespace Challenge.Players
{
    public class ConsoleHumanPlayer : Player
    {
        public override IShape GetShape(ShapeFactory shapeFactory)
        {
            Console.Write($"{Name}'s turn: Choose [R]ock [S]pock [P]aper [L]izard s[C]issors: ");
            var input = Console.ReadLine();
            switch (input.ToUpper())
            {
                case "R": return shapeFactory.GetShape(Shape.Rock);
                case "S": return shapeFactory.GetShape(Shape.Spock);
                case "P": return shapeFactory.GetShape(Shape.Paper);
                case "L": return shapeFactory.GetShape(Shape.Lizard);
                case "C": return shapeFactory.GetShape(Shape.Scissors);
                default:
                    Console.WriteLine("Not valid selection!");
                    return GetShape(shapeFactory);
            }
        }
    }
}