using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Area
    {
        public Area()
        {
            this.CurrentUpgradeLevel = UpgradeLevelType.None;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? OwnerId { get; set; }

        public int BuyAmount { get; set; }

        public AreaType AreaType { get; set; }

        public bool HasUpgrades { get; set; }

        public UpgradeLevelType CurrentUpgradeLevel { get; set; }

        public ICollection<UpgradeLevel> UpgradeLevels { get; set; }
    }
}