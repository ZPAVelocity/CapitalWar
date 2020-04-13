using System;

namespace CapitalWar.Info
{
    /// <summary>
    /// 资产信息
    /// </summary>
    class PropertyInfo
    {
        public int id;
        public string name;
        public string description;
        public double value;
        public double upgradeCost;
        public int level = 0;
        public int[] tolls;
        public bool isMortgaged = false;
        public double mortgageValue;
        public PlayerInfo owner;

        public PropertyInfo(int id, string name, string description, int value,
            int upgradeCost, int[] tolls, int mortgageValue, PlayerInfo owner)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.value = value;
            this.upgradeCost = upgradeCost;
            this.tolls = tolls;
            this.mortgageValue = mortgageValue;
            this.owner = owner;
        }

    }

}