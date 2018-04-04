using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Player
    {
        private const int _defaultWalletBalance = 1500;

        public Player()
        {
            this.WalletBalance = _defaultWalletBalance;
            this.CurrentPositionId = 0;
        }

        public int Id { get; set; }

        public PlayerType PlayerType { get; set; }

        public int WalletBalance { get; set; }

        public int CurrentSteps { get; protected set; }

        public Area CurrentPosition { get; protected set; }

        public int CurrentPositionId { get; protected set; }

        public void CastCubes()
        {
            int one = RandomNumberUtility.GetRandomNumber();
            int two = 0; //RandomNumberUtility.GetRandomNumber();

            int sum = one + two;

            this.CurrentSteps = sum;
        }

        public Area MoveTo(ICollection<Area> areas)
        {
            int maxAreasPositions = areas.Count();

            int nextPosition = this.CurrentPositionId + this.CurrentSteps + 1;

            if(nextPosition > maxAreasPositions)
            {
                nextPosition = nextPosition - maxAreasPositions;
            }

            var area = areas.SingleOrDefault(x => x.Id == nextPosition); //TODO: FIND BETTER LOGIC FOR THAT.
            this.CurrentPosition = area;
            this.CurrentPositionId = area.Id;

            return area;
        }

        public void AddAmount(int amount)
        {
            this.WalletBalance = this.WalletBalance + amount;
        }

        public void RemoveAmount(int amount)
        {
            this.WalletBalance = this.WalletBalance - amount;
        }
    }
}