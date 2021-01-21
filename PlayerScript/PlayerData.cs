using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace GameObjects
{

    namespace Player
    {

        [CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Player", order = 1)]
        public sealed class PlayerData : ScriptableObject
        {
            public PlayerStruct playerStruct;
        }

    }


}
