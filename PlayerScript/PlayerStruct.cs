using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameObjects
{

    namespace Player
    {

        [Serializable]
        public struct PlayerStruct
        {

            #region Fields

            public GameObject player;
            public float speed;
            public float hp;
            public Vector3 spawnPosition;

            #endregion
        }

    }

}

