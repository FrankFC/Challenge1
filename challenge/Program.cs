using System;
using Challenge.Logic;
using Challenge.Players;
using Challenge.Shapes;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            var player1 = new ConsoleHumanPlayer(shapeFactory) { Name = "Frank" };
            var player2 = new MachinePlayer(shapeFactory) { Name = "PC" };

            Console.Write("Use decision machine? (Y): ");
            var userReponse = Console.ReadLine();

            var useDecisionMachine = userReponse.Equals("Y", StringComparison.InvariantCultureIgnoreCase);

            var game = new Game(player1, player2, useDecisionMachine);
            game.ShapePlayedEvent += Game_ShapePlayedEvent;

            do
            {
                Console.WriteLine($"Player 1 : {player1.Name}");
                Console.WriteLine($"Player 2 : {player2.Name}");

                var roundResult = game.PlayNewRound();

                Console.WriteLine($"Result: {(roundResult.IsDraw ? "Draw" : $"{roundResult.WinnerPlayer.Name} Wins!")}");

                Console.Write("Play again? (Y): ");
                userReponse = Console.ReadLine();
                Console.WriteLine("=====================================================");
            } while (userReponse.Equals("Y", StringComparison.InvariantCultureIgnoreCase));
        }

        private static void Game_ShapePlayedEvent(Player player, IShape shape)
        {
            Console.WriteLine($"{player.Name} played shape {shape.Name}");
        }
    }
}
