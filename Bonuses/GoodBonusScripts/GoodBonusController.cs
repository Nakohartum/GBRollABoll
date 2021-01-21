using System;

namespace Bonuses
{
    public abstract class GoodBonusController : BonusController
    {
        protected GoodBonusModel _goodBonusModel;
        protected GoodBonusStruct _acessor;
        protected GoodBonusView _bonusView;
        

        public GoodBonusController(GoodBonusModel goodBonusModel)
        {
            this._goodBonusModel = goodBonusModel;
            this._acessor = _goodBonusModel.GoodBonusStruct;
            this._bonusView = _acessor.Bonus.GetComponent<GoodBonusView>();
            if (_bonusView == null)
            {
                throw new ArgumentNullException("GoodBonusView is not on an object");
            }
        }
        
    }
}