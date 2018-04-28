using System.ComponentModel;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public class Spock : IShape
    {
        public string Name => "Spock";

        public DecisionResult Versus(IShape other)
        {
            var result = new DecisionResult();
            switch (other)
            {
                case Scissors _:
                case Rock _:
                    result.WinnerShape = this;
                    break;
                case Paper _:
                case Lizard _:
                    result.WinnerShape = other;
                    break;
                case Spock _:
                    result.IsDraw = true;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}