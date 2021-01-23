using System.Collections.Generic;
using Game;
using UnityEngine;

namespace Bonuses
{
    public class GoodBonusInitializator
    {
        public GoodBonusInitializator(MainController mainController, List<GoodBonusData> goodBonusDatas)
        {
            foreach (var goodBonusData in goodBonusDatas)
            {
                var spawnedBonus = Object.Instantiate(goodBonusData.GoodBonusStruct.BonusStruct.Bonus,
                    goodBonusData.GoodBonusStruct.BonusStruct.SpawnPosition, Quaternion.identity);

                var bonusStruct = goodBonusData.GoodBonusStruct;
                bonusStruct.BonusStruct.Bonus = spawnedBonus;

                var goodBonusModel = new GoodBonusModel(bonusStruct);
            
                mainController.AddUpdatable(new GoodBonusController(goodBonusModel));
            }
        }
    }
}