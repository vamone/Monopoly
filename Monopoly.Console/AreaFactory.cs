using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monopoly.Console.Program;

namespace Monopoly.Console
{
    public static class AreaFactory
    {
        public static IEnumerable<Area> GetAreasInternal()
        {
            yield return new Area {
                Id = 1,
                Name = "Start Point",
                AreaType = AreaType.Start,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None
                    }
                }
            };

            yield return new Area
            {
                Id = 2,
                Name = "Street 1",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 3,
                Name = "Street 2",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 4,
                Name = "Free",
                AreaType = AreaType.Free              
            };

            yield return new Area
            {
                Id = 5,
                Name = "Street 3",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 6,
                Name = "Street 4",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 7,
                Name = "Bank",
                AreaType = AreaType.Bank
            };

            yield return new Area
            {
                Id = 8,
                Name = "Street 5",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 9,
                Name = "Street 6",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 10,
                Name = "Go to prison",
                AreaType = AreaType.GoToPrison
            };

            yield return new Area
            {
                Id = 11,
                Name = "Street 7",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };

            yield return new Area
            {
                Id = 12,
                Name = "Street 8",
                AreaType = AreaType.Street,
                CurrentUpgradeLevel = UpgradeLevelType.None,
                BuyAmount = 102,
                HasUpgrades = true,
                UpgradeLevels = new List<UpgradeLevel>
                {
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.None,
                        RentPrice = 15
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.OneHouse,
                        RentPrice = 25
                    },
                    new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.TwoHouses,
                        RentPrice = 35
                    },
                     new UpgradeLevel
                    {
                        UpgradeLevelType = UpgradeLevelType.Hotel,
                        RentPrice = 150
                    }
                }
            };
        }
    }
}