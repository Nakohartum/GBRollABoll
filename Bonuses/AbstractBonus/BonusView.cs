using System;
using GameObjects.Player;
using UnityEngine;

namespace Bonuses
{
    public class BonusView : MonoBehaviour
    {
        public BonusContoller _bonusContoller;
        public Action<PlayerModel> onInteract;
    }
}