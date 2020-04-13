using System;

namespace CapitalWar.Info
{
    /// <summary>
    /// 地图信息
    /// </summary>
    class MapInfo
    {
        public PropertyInfo[] property;
        public CardInfo[] card;
        public PlayerInfo[] player;

        public MapInfo(int playerNum)
        {
            property = new PropertyInfo[Global.PROPERTY_NUM];
            card = new CardInfo[Global.CARD_NUM];
            player = new PlayerInfo[playerNum];
        }
    }
}


