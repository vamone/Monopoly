using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RuleEngine
    {
        public void Calculate(Area area, Player player)
        {
            if(area.AreaType == AreaType.Street && area.OwnerId == null)
            {
                area.OwnerId = player.Id;
                player.RemoveAmount(area.BuyAmount);
            }
        }
    }
}
