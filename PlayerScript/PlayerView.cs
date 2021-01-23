using System;
using System.Collections;
using System.Collections.Generic;
using Bonuses;
using GameObjects.Player;
using Interfaces;
using UnityEngine;

public sealed class PlayerView : MonoBehaviour
{
    public PlayerModel _playerModel;
    public PlayerController Controller;
    

    private void OnTriggerEnter(Collider other)
    {
        BonusView bonusView;
        other.TryGetComponent<BonusView>(out bonusView);
        Debug.Log(bonusView);
        if (bonusView != null)
        {
            bonusView.onInteract?.Invoke(_playerModel);
            Debug.Log(_playerModel._playerStruct._currentHP);
            Debug.Log(_playerModel._playerStruct.speed);
            
        }
    }
}
