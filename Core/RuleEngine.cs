using System.Linq;

namespace Core
{
    public class RuleEngine
    {
        public string Calculate(Area area, Player player)
        {
            if(area.AreaType == AreaType.Street && area.OwnerId == null)
            {
                area.OwnerId = player.Id;
                area.Owner = player;
                player.RemoveAmount(area.BuyAmount);

                return string.Format("{0} bought the {1} for {2}.", player.PlayerType, area.Name, area.BuyAmount);
            }

            if (area.AreaType == AreaType.Street && area.OwnerId > 0 && area.OwnerId != player.Id)
            {
                var upgradeLavel = area.UpgradeLevels.SingleOrDefault(x => x.UpgradeLevelType == area.CurrentUpgradeLevel);
                if (upgradeLavel != null)
                {
                    player.RemoveAmount(upgradeLavel.RentPrice);
                    area.Owner.AddAmount(upgradeLavel.RentPrice);

                    return string.Format("{0} paid rent to {1} of {2}.", player.PlayerType, area.Owner.PlayerType, upgradeLavel.RentPrice);
                }
            }

            if(area.AreaType == AreaType.Free)
            {
                return "Free area.";
            }

            return null;
        }
    }
}