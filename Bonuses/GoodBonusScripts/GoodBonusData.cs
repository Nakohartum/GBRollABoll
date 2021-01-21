using UnityEngine;

namespace Bonuses
{
    [CreateAssetMenu(fileName = "GoodBonus", menuName = "Bonuses/GoodBonus", order = 1)]
    public class GoodBonusData : ScriptableObject
    {
        public GoodBonusStruct GoodBonusStruct;
    }
}