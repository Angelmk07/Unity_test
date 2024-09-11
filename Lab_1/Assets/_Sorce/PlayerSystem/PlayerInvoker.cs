using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker 
{
    private PlayerMovment _playerMovment;
    private Player _playerRb;
    public PlayerInvoker()
    {
        _playerMovment = new PlayerMovment();
    }
    public void InvokeJump()
    {
        _playerMovment.Jump(_playerRb.Rb,);
    }
}
