using System.ComponentModel;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public class Rock : IShape
    {
        public string Name => "Rock";

        public DecisionResult Versus(IShape other)
        {
            var result = new DecisionResult();
            switch (other)
            {
                case Scissors _:
                case Lizard _:
                    result.WinnerShape = this;
                    break;
                case Paper _:
                case Spock _:
                    result.WinnerShape = other;
                    break;
                case Rock _:
                    result.IsDraw = true;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}