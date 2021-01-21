using System;
using UnityEngine;

namespace Bonuses
{
    [Serializable]
    public abstract class BonusStruct
    {
        public Vector3 SpawnPosition;
        public GameObject Bonus;
        public string BonusType;
        public BonusBuff BonusBuff;
    }
}