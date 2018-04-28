using System.ComponentModel;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public class Scissors : IShape
    {
        public string Name => "Scissors";

        public DecisionResult Versus(IShape other)
        {
            var result = new DecisionResult();
            switch (other)
            {
                case Paper _:
                case Lizard _:
                    result.WinnerShape = this;
                    break;
                case Spock _:
                case Rock _:
                    result.WinnerShape = other;
                    break;
                case Scissors _:
                    result.IsDraw = true;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}