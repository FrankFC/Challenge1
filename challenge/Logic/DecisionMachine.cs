using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Shapes;

namespace Challenge.Logic
{
    public class DecisionMachine
    {
        private readonly Dictionary<Type, List<Type>> _winningRules;

        public DecisionMachine(Dictionary<Type, List<Type>> winningRules)
        {
            _winningRules = winningRules;
        }

        public DecisionMachine()
        {
            _winningRules = new Dictionary<Type, List<Type>>
            {
                {typeof(Rock), new List<Type>() {typeof(Scissors), typeof(Lizard)}},
                {typeof(Scissors), new List<Type>() {typeof(Paper), typeof(Lizard)}},
                {typeof(Paper), new List<Type>() {typeof(Rock), typeof(Spock)}},
                {typeof(Lizard), new List<Type>() {typeof(Spock), typeof(Paper)}},
                {typeof(Spock), new List<Type>() {typeof(Scissors), typeof(Rock)}}
            };

        }

        public DecisionResult GetResult(IShape shape1, IShape shape2)
        {
            var result = new DecisionResult();

            if (shape1 == shape2)
            {
                result.IsDraw = true;
            }

            if (_winningRules.ContainsKey(shape1.GetType()))
            {
                result.WinnerShape = _winningRules[shape1.GetType()].Contains(shape2.GetType()) ? shape1 : shape2;
            }
            else
            {
                throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}
