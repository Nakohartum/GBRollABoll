using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameObjects
{

    namespace Player
    {

        public sealed class PlayerController : IUpdatable
        {

            #region Fields

            private PlayerModel _playerModel;
            private PlayerStruct _playerAccessor;
            private PlayerView _playerView;
            

            #endregion

            #region Methods

            public PlayerController(PlayerModel playerModel)
            {
                _playerModel = playerModel;
                _playerAccessor = _playerModel._playerStruct;
                _playerView = _playerModel._playerStruct.player.GetComponent<PlayerView>();
                
            }

            public void UpdateTick()
            {
                float moveVertical = Input.GetAxis("Vertical");
                float moveHorizontal = Input.GetAxis("Horizontal");



                Vector3 movement = new Vector3(-moveHorizontal, 0, -moveVertical);
                movement.Normalize();
                _playerAccessor.player.transform.Translate(movement * _playerAccessor.speed * Time.deltaTime);

                
               
            }

            #endregion

        }

    }
    
}

