using System;
using System.Collections.Generic;

namespace CapitalWar.DataModel
{
    /// <summary>
    /// 地图信息
    /// </summary>
    class MapInfo
    {
        private List<PlaceInfo> place = new List<PlaceInfo>();
        private List<CardInfo> card = new List<CardInfo>();
        private List<PlayerInfo> player = new List<PlayerInfo>();

        public MapInfo()
        {

        }

        public void StartNewGame()
        {
        }

        public void LoadGame()
        {

        }

        public void LoadPlaceInfo(string path)
        {
            foreach (PlaceInfo i in place)
            {
            }
        }

        public void LoadCardInfo(string path)
        {
            foreach (CardInfo i in card)
            {
            }
        }

        public void LoadPlayerInfo(string path)
        {
            foreach (PlayerInfo i in player)
            {
            }
        }

        public void ChangePlayerLocation(PlayerInfo player, int locationMearsure)
        {
            // 排除破产玩家
            if (player.isBankrupted == true)
            {
                return;
            }

            // 过家酬劳
            for (int i = 1; i < locationMearsure; i++)
            {
                if ((player.location + i) % Global.PLACE_NUM == 0)
                {
                    player.AddAsset(5000);
                }
            }

            //移动
            player.AddLocation(locationMearsure);

            // 空地
            if (place[player.location].type == Global.PlaceType.none ||
                place[player.location].type == Global.PlaceType.home)
            {
                return;
            }
            // 监狱
            else if (place[player.location].type == Global.PlaceType.prison)
            {
                player.isImprisoned = true;
                return;
            }
            // 卡牌
            else if (place[player.location].type == Global.PlaceType.card)
            {
                return;
            }
            // 资产
            else if (place[player.location].type == Global.PlaceType.estate)
            {
                if (place[player.location].owner == null)
                {
                    player.BuyProperty(place[player.location]);
                }
                else if (place[player.location].owner == player)
                {
                    player.UpgradeProperty(place[player.location]);
                }
                else if (place[player.location].owner != player)
                {
                    player.PayTolls(place[player.location]);
                }
            }

        }

        public int RollDice()
        {
            Random ra = new Random();
            return ra.Next(1, 13);
        }
    }
}


