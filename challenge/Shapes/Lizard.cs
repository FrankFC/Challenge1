using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using Challenge.Logic;

namespace Challenge.Shapes
{
    public class Lizard : IShape
    {
        public string Name => "Lizard";

        public DecisionResult Versus(IShape other)
        {
            var result = new DecisionResult();
            switch (other)
            {
                case Paper _:
                case Spock _:
                    result.WinnerShape = this;
                    break;
                case Rock _:
                case Scissors _:
                    result.WinnerShape = other;
                    break;
                case Lizard _:
                    result.IsDraw = true;
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}