using System;


namespace Bonuses
{
    [Serializable]
    public struct GoodBonusStruct
    {
        public enum GoodBonusTypes
        {
            Healer, Speeder
        }
        public BonusStruct BonusStruct;
        public float HPGive;
        public float SpeedGive;
        public GoodBonusTypes GoodBonusType;
    }
}