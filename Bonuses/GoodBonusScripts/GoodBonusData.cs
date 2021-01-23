using UnityEngine;

namespace Bonuses
{
    [CreateAssetMenu(fileName = "GoodBonus", menuName = "Bonuses/GoodBonus", order = 0)]
    public class GoodBonusData : ScriptableObject
    {
        public GoodBonusStruct GoodBonusStruct;
    }
}