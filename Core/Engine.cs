using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Engine
    {
        public Engine(ICollection<Area> areas, ICollection<Player> players)
        {
            this.Areas = areas;
            this.Players = players;
            this.BankBalance = 0;
        }

        public ICollection<Area> Areas { get; set; }

        public ICollection<Player> Players { get; set; }

        public int BankBalance { get; set; }

        public Player CurrentPlayer { get; set; }

        public bool IsGameStarted { get; set; }

        public void Start()
        {
            this.IsGameStarted = true;
        }

        public ProgressResults Play()
        {
            var result = new ProgressResults();

            var ruleEngine = new RuleEngine();

            foreach (var player in this.Players)
            {
                if(player.Id == this.CurrentPlayer.Id)
                {
                    continue;
                }

                this.CurrentPlayer = player;
                var area = player.MoveTo(this.Areas);
                ruleEngine.Calculate(area, player);

                result.PlayerType = player.PlayerType.ToString();
                result.WalletBalance = player.WalletBalance;
                result.CurrentSteps = player.CurrentSteps;
            }

            return result;
        }

        public void Pause()
        {
            this.IsGameStarted = false;
        }

        public void NextPlayer()
        {
            int nextPlayerId = this.CurrentPlayer.Id + 1;

            var nextPlayer = this.Players.SingleOrDefault(x => x.Id == nextPlayerId);
            if (nextPlayer == null)
            {
                this.CurrentPlayer = this.Players.FirstOrDefault();

                return;
            }

            this.CurrentPlayer = nextPlayer;
        }

        public void InitPlayers()
        {
            var orderedPlayers = this.Players.OrderBy(x => x.CurrentSteps).ToList();

            int i = 0;
            foreach (var player in orderedPlayers)
            {
                i++;
                player.Id = i;
            }

            this.Players = orderedPlayers;

            var firstPlayer = this.Players.FirstOrDefault();

            this.CurrentPlayer = firstPlayer;
        }
    }
}