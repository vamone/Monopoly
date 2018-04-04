using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player
            {
                PlayerType = PlayerType.Boat,
            };

            playerOne.CastCubes();

            var playerTwo = new Player
            {
                PlayerType = PlayerType.Car,
            };

            playerTwo.CastCubes();

            var areas = AreaFactory.GetAreasInternal().ToList();

            var players = new List<Player>();
            players.Add(playerOne);
            players.Add(playerTwo);

            var engine = new Engine(areas, players);
            engine.InitPlayers();
            engine.Start();

            int i = 0;
            while(engine.IsGameStarted)
            {
                i++;

                bool isGameStarted = i > 1;
                engine.Play(isGameStarted);

                var results = engine.GetProgress();
                foreach (var result in results)
                {
                    System.Console.WriteLine(result.PlayerType + " -> Steps: " + result.CurrentSteps + " Area: " + result.AreaName);
                    System.Console.WriteLine(result.Message);
                    System.Console.WriteLine("Balance: " + result.WalletBalance);

                    System.Console.WriteLine();
                }

                System.Console.WriteLine(playerOne.PlayerType + " Balance: "  + playerOne.WalletBalance);
                System.Console.WriteLine(playerTwo.PlayerType + " Balance: " + playerTwo.WalletBalance);

                System.Console.WriteLine();

                System.Console.WriteLine("Press Enter to continue...");

                System.Console.ReadLine();
            }

            System.Console.ReadLine();
        }

        
    }
}
