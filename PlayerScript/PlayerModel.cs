using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameObjects
{

    namespace Player
    {

        public class PlayerModel
        {

            #region Fields

            public PlayerStruct _playerStruct;

            #endregion

            #region Methods

            public PlayerModel(PlayerStruct playerStruct)
            {
                _playerStruct = playerStruct;
                
            }

            #endregion

        }

    }

}

