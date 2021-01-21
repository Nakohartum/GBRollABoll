using Game;
using UnityEngine;

namespace Bonuses
{
    public class GoodBonusInitializator
    {
        public GoodBonusInitializator(MainController mainController, GoodBonusData goodBonusData)
        {
            var bonus = Object.Instantiate(goodBonusData.GoodBonusStruct.Bonus,
                goodBonusData.GoodBonusStruct.SpawnPosition, Quaternion.identity);

            var bonusStruct = goodBonusData.GoodBonusStruct;
            bonusStruct.Bonus = bonus;

            var bonusModel = new GoodBonusHealerModel(bonusStruct);
            mainController.AddUpdatable(new GoodBonusHealerController(bonusModel));
            
            
        }
    }
}