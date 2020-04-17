using System;
using System.Collections.Generic;

using CapitalWar;

namespace CapitalWar.DataModel
{
    /// <summary>
    /// 位置信息
    /// </summary>
    class PlaceInfo
    {
        #region 构造函数

        public PlaceInfo(int id, string name, Global.PlaceType type,
            double value, double upgradeCost, double[] tolls, double mortgageValue)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.value = value;
            this.upgradeCost = upgradeCost;
            this.level = 0;
            this.tolls = tolls;
            this.isMortgaged = false;
            this.mortgageValue = mortgageValue;
            this.owner = null;
        }

        public PlaceInfo(int id, string name, Global.PlaceType type,
            double value, double upgradeCost, int level, double[] tolls,
            bool isMortgaged, double mortgageValue, PlayerInfo owner)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.value = value;
            this.upgradeCost = upgradeCost;
            this.level = level;
            this.tolls = tolls;
            this.isMortgaged = isMortgaged;
            this.mortgageValue = mortgageValue;
            this.owner = owner;

        }

        #endregion

        public int id;
        public string name;
        public Global.PlaceType type;
        public double value;
        public double upgradeCost;
        public int level;
        public double[] tolls = new double[Global.MAX_LEVEL + 1];
        public bool isMortgaged;
        public double mortgageValue;
        public PlayerInfo owner;

    }

}