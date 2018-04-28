using Challenge.Players;
using Challenge.Shapes;

namespace Challenge.Logic
{
    public class Game
    {
        public delegate void ShapePlayedEventHandler(Player player, IShape shape);
        public event ShapePlayedEventHandler ShapePlayedEvent;

        public Player Player1 { get; }
        public Player Player2 { get; }

        private readonly DecisionMachine _decisionMachine;
        private readonly bool _useDecisionMachine;

        private readonly ShapeFactory _shapeFactory;
        public Game(Player player1, Player player2, bool useDecisionMachine)
        {
            Player1 = player1;
            Player2 = player2;

            _shapeFactory = new ShapeFactory();

            _useDecisionMachine = useDecisionMachine;

            if (useDecisionMachine)
                _decisionMachine = new DecisionMachine();
        }

        public DecisionResult PlayNewRound()
        {
            var shape1 = Player1.GetShape(_shapeFactory);
            OnShapePlayed(Player1, shape1);

            var shape2 = Player2.GetShape(_shapeFactory);
            OnShapePlayed(Player2, shape2);

            DecisionResult decisionResult;

            if (_useDecisionMachine)
            {
                decisionResult = _decisionMachine.GetResult(shape1, shape2);
            }
            else
            {
                decisionResult = shape1.Versus(shape2);
            }
            decisionResult.WinnerPlayer = decisionResult.WinnerShape == shape1 ? Player1 : Player2;
            return decisionResult;
        }

        private void OnShapePlayed(Player player, IShape shape)
        {
            if (ShapePlayedEvent != null)
                ShapePlayedEvent.Invoke(player, shape);
        }
    }
}