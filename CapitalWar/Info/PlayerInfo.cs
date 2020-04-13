using System;

namespace CapitalWar.Info
{
    /// <summary>
    /// 玩家信息
    /// </summary>
    class PlayerInfo
    {
        public int id;
        public string name;
        public double asset;
        public PropertyInfo[] property;
        public int location = 0;
        public int priority = -1;
        public int count = 0;

        public PlayerInfo(int id, string name, double asset)
        {
            this.id = id;
            this.name = name;
            this.asset = asset;
            this.location = 0;
            this.priority = -1;
            this.count = 0;
        }

        public bool BuyProperty(PropertyInfo property)
        {
            if (this.asset >= property.value)
            {
                this.asset -= property.value;
                property.owner = this;
                return true;
            }
            return false;
        }

        public bool UpgradeProperty(PropertyInfo property)
        {
            if (property.owner == this)
            {
                if (this.asset >= property.upgradeCost)
                {
                    this.asset -= property.upgradeCost;
                    return true;
                }
            }
            return false;
        }

        public bool MortgageProperty(PropertyInfo property)
        {
            if (property.owner == this)
            {
                property.isMortgaged = true;
                this.asset += property.mortgageValue;
                return true;
            }
            return false;
        }

        public bool RedeemProperty(PropertyInfo property)
        {
            if (property.owner == this && property.isMortgaged == true)
            {
                if (this.asset >= property.mortgageValue * 1.2)
                {
                    this.asset -= property.mortgageValue * 1.2;
                    property.isMortgaged = false;
                    return true;
                }
            }
            return false;
        }


    }
}