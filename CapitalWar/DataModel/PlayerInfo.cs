using System;
using System.Collections.Generic;

namespace CapitalWar.DataModel
{
    /// <summary>
    /// 玩家信息
    /// </summary>
    class PlayerInfo
    {
        #region 构造函数

        public PlayerInfo(int id, string name, int priority)
        {
            this.id = id;
            this.name = name;
            this.asset = 50000;
            this.estateList = null;
            this.location = 0;
            this.priority = priority;
            this.isImprisoned = false;
            this.isBankrupted = false;
        }

        public PlayerInfo(int id, string name, double asset, List<PlaceInfo> estateList,
            int location, int priority, bool isImprisoned, bool isBankrupted)
        {
            this.id = id;
            this.name = name;
            this.asset = asset;
            this.estateList = estateList;
            this.location = location;
            this.priority = priority;
            this.isImprisoned = isImprisoned;
            this.isBankrupted = isBankrupted;
        }

        #endregion

        public int id;
        public string name;
        public double asset;
        public List<PlaceInfo> estateList;
        public int location;
        public int priority;
        public bool isImprisoned;
        public bool isBankrupted;

        #region 方法

        public void PayTolls(PlaceInfo estate)
        {
            if (estate.owner != this && estate.owner != null &&
                estate.isMortgaged == false && this.asset >= estate.tolls[estate.level])
            {
                this.asset -= estate.tolls[estate.level];
                estate.owner.asset += estate.tolls[estate.level];

            }
            else if (this.asset < estate.tolls[estate.level])
            {
                
            }
        }

        public bool BuyProperty(PlaceInfo estate)
        {
            if (estate.owner == null
                && this.asset >= estate.value)
            {
                this.asset -= estate.value;
                estate.owner = this;
                this.estateList.Add(estate);
                return true;
            }
            return false;
        }

        public bool UpgradeProperty(PlaceInfo estate)
        {
            if (estate.owner == this
                && this.asset >= estate.upgradeCost
                && estate.level <= Global.MAX_LEVEL)
            {
                this.asset -= estate.upgradeCost;

                return true;
            }
            return false;
        }

        public bool MortgageProperty(PlaceInfo estate)
        {
            if (estate.owner == this)
            {
                estate.isMortgaged = true;
                this.asset += estate.mortgageValue;
                return true;
            }
            return false;
        }

        public bool RedeemProperty(PlaceInfo estate)
        {
            if (estate.owner == this
                && estate.isMortgaged == true)
            {
                if (this.asset >= estate.mortgageValue * 1.2)
                {
                    this.asset -= estate.mortgageValue * 1.2;
                    estate.isMortgaged = false;
                    return true;
                }
            }
            return false;
        }

        public void AddAsset(int assetMearsure)
        {
            this.asset += assetMearsure;
        }

        public void AddLocation(int locationMearsure)
        {
            this.location = (this.location + locationMearsure) % Global.PLACE_NUM;
        }

        public void ChangeAsset(int assetMearsure)
        {
            this.asset = assetMearsure;
        }

        public void ChangeLocation(int locationMearsure)
        {
            this.location = locationMearsure;
        }

        public void GoBankrupt()
        {
            foreach (PlaceInfo i in estateList)
            {
                i.owner = null;
                i.isMortgaged = false;
            }
            estateList.Clear();
        }

        #endregion
    }
}