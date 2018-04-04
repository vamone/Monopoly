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
            this.ProgressResults = this.ProgressResults ?? new List<ProgressResults>();
        }

        public ICollection<Area> Areas { get; set; }

        public ICollection<Player> Players { get; set; }

        public int BankBalance { get; set; }

        public Player CurrentPlayer { get; set; }

        public bool IsGameStarted { get; set; }

        public ICollection<ProgressResults> ProgressResults { get; set; }

        public void Start()
        {
            this.IsGameStarted = true;
        }

        public ICollection<ProgressResults> GetProgress()
        {
            return this.ProgressResults;
        }

        public void Play(bool isGameStarted = false)
        {
            this.ProgressResults.Clear();

            var ruleEngine = new RuleEngine();
            foreach (var player in this.Players)
            {
                var progress = new ProgressResults();

                if(isGameStarted)
                {
                    player.CastCubes();
                }

                this.CurrentPlayer = player;
                var area = player.MoveTo(this.Areas);

                string calculateResult = ruleEngine.Calculate(area, player);
                progress.Message = calculateResult;

                progress.PlayerType = player.PlayerType.ToString();
                progress.WalletBalance = player.WalletBalance;
                progress.CurrentSteps = player.CurrentSteps;
                progress.AreaName = area.Name;

                this.ProgressResults.Add(progress);
            }
        }

        public void Pause()
        {
            this.IsGameStarted = false;
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
        }
    }
}