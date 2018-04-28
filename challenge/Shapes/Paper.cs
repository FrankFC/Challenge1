using System.ComponentModel;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public class Paper : IShape
    {
        public string Name => "Paper";

        public DecisionResult Versus(IShape other)
        {
            var result = new DecisionResult();
            switch (other)
            {
                case Rock _:
                case Spock _:
                    result.WinnerShape = this;
                    break;
                case Lizard _:
                case Scissors _:
                    result.WinnerShape = other;
                    break;
                case Paper _:
                    result.IsDraw = true;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}