using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameObjects
{

    namespace Player
    {

        public sealed class PlayerInitializator
        {

            #region Methods

            public PlayerInitializator(MainController mainController, PlayerData playerData)
            {
                var spawnedPlayer = Object.Instantiate(playerData.playerStruct.player, playerData.playerStruct.spawnPosition, Quaternion.identity);
               

                var _playerStruct = playerData.playerStruct;
                _playerStruct.player = spawnedPlayer;
                
                var playerModel = new PlayerModel(_playerStruct);
                
                mainController.AddUpdatable(new PlayerController(playerModel));
                
            }

            #endregion

        }

    }

}
