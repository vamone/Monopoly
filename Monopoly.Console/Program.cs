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

            while(engine.IsGameStarted)
            {
                var result = engine.Play();

                System.Console.WriteLine(result.PlayerType + " -> Steps: " + result.CurrentSteps);
                System.Console.WriteLine("Balance: " + result.WalletBalance);

                System.Console.ReadLine();
            }

            System.Console.ReadLine();
        }

        
    }
}
