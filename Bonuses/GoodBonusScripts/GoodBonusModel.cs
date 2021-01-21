namespace Bonuses
{
    public abstract class GoodBonusModel
    {
        public GoodBonusStruct GoodBonusStruct;

        public GoodBonusModel(GoodBonusStruct goodBonusStruct)
        {
            this.GoodBonusStruct = goodBonusStruct;
        }
    }
}