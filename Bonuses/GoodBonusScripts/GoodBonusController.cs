using GameObjects.Player;
using UnityEngine;

namespace Bonuses
{
    public class GoodBonusController : BonusContoller
    {
        protected GoodBonusModel _goodBonusModel;
        protected GoodBonusStruct _accessor;
        protected BonusView _bonusView;


        public GoodBonusController(GoodBonusModel goodBonusModel)
        {
            this._goodBonusModel = goodBonusModel;
            _accessor = goodBonusModel.GoodBonusStruct;
            _bonusView = _accessor.BonusStruct.Bonus.GetComponent<BonusView>();
            _bonusView._bonusContoller = this;
            _bonusView.onInteract += Interact;
        }
        
        public override void UpdateTick()
        {
            
        }

        public override void Interact(PlayerModel playerModel)
        {
            if (GetBonusType() == GoodBonusStruct.GoodBonusTypes.Healer)
            {
                Heal(playerModel);
            }
            else if (GetBonusType() == GoodBonusStruct.GoodBonusTypes.Speeder)
            {
                SpeedUp(playerModel);
            }
        }

        private void Heal(PlayerModel playerModel)
        {
            if (playerModel._playerStruct._currentHP < playerModel._playerStruct.hp)
            {
                playerModel._playerStruct._currentHP += _accessor.HPGive;
                Debug.Log($"HP gain {_accessor.HPGive}. Current HP: {playerModel._playerStruct._currentHP}");
            }
            else
            {
                Debug.Log("Too many hp");
            }
        }
        
        private void SpeedUp(PlayerModel playerModel)
        {
            
        }
        
        public GoodBonusStruct.GoodBonusTypes GetBonusType()
        {
            return _goodBonusModel.GoodBonusStruct.GoodBonusType;
        }
    }
}