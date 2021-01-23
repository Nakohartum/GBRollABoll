using GameObjects.Player;
using Interfaces;
using System.Collections;
using System.Collections.Generic;
using Bonuses;
using UnityEngine;


namespace Game
{

    public class MainController : MonoBehaviour
    {

        #region Fields

        [SerializeField] private PlayerData _playerData;
        [SerializeField] private List<GoodBonusData> _goodBonusData;
        private List<IUpdatable> updatables = new List<IUpdatable>();

        #endregion

        #region Methods

        void Start()
        {
            new InitializeController(this, _playerData, _goodBonusData);
        }

        // Update is called once per frame
        void Update()
        {

            for (int i = 0; i < updatables.Count; i++)
            {
                updatables[i].UpdateTick();
            }

        }

        public void AddUpdatable(IUpdatable updatable)
        {
            updatables.Add(updatable);
        }


        #endregion

    }

}

