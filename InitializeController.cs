using GameObjects.Player;
using System.Collections;
using System.Collections.Generic;
using Bonuses;
using UnityEngine;


namespace Game
{

    public class InitializeController 
    {

        public InitializeController(MainController mainController, PlayerData playerData, List<GoodBonusData> goodBonusDatas)
        {
            new PlayerInitializator(mainController, playerData);
            new GoodBonusInitializator(mainController, goodBonusDatas);

        }

    }

}

