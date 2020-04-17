using System;
using System.Collections.Generic;

namespace CapitalWar.DataModel
{
    /// <summary>
    /// 卡牌信息
    /// </summary>
    class CardInfo
    {
        private int id;
        private string name;
        private double changeAsset;
        private int changeLocation;

        public CardInfo(int id, string name, double changeAsset, int changeLocation)
        {
            this.id = id;
            this.name = name;
            this.changeAsset = changeAsset;
            this.changeLocation = changeLocation;
        }
    }

}