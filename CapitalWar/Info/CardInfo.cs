using System;

namespace CapitalWar.Info
{
    /// <summary>
    /// 卡牌信息
    /// </summary>
    class CardInfo
    {
        public int id;
        public string name;
        public PlayerInfo user;
        public double asset;
        public int location;

        public CardInfo(int id, string name, PlayerInfo user, double asset, int location)
        {
            this.id = id;
            this.name = name;
            this.user = user;
            this.asset = asset;
            this.location = location;
        }

        public void ChangeAsset()
        {
            user.asset += asset;
        }
        public void ChangeLocation()
        {
            user.location += location;
        }
    }

}