using System;
using GameObjects.Player;
using Interfaces;
using UnityEngine;

namespace Bonuses
{
    [Serializable]
    internal sealed class GoodBonusHealerController : GoodBonusController, IBuffer
    {
        private float groundOffset = 3.0f;
        private float currentOffset = 0.0f;
        public GoodBonusHealerController(GoodBonusModel goodBonusModel) : base(goodBonusModel)
        {
        }

        public override void UpdateTick()
        {
            if (currentOffset < groundOffset)
            {
                _acessor.Bonus.transform.Translate(Vector3.up * Time.deltaTime);
                currentOffset += Time.deltaTime;
            }
            else
            {
                _acessor.Bonus.transform.Translate(Vector3.down * Time.deltaTime);
                currentOffset -= Time.deltaTime;
            }
           
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }

        public void Buff(PlayerStruct playerStruct)
        {
            if (playerStruct.hp < 100)
            {
                playerStruct.hp += _goodBonusModel.GoodBonusStruct.HpGiven;
            }
        }
    }

    
}