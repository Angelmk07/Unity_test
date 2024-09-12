using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker 
{
    private PlayerMovment _playerMovment;
    private Player _player;
    private InputLisener _inputs;
    public PlayerInvoker(PlayerMovment playerMovment, Player player, InputLisener inputs)
    {
        _playerMovment = playerMovment;
        _player = player;
        _inputs = inputs;
    }
    public PlayerInvoker()
    {
        _playerMovment = new PlayerMovment();
    }
    public void InvokeJump()
    {
        _playerMovment.Jump(_player.Rb, _player.Force);
    }
    public void InvokeMove( )
    {

        _playerMovment.Move(_inputs.X_Keyboard, _inputs.Z_Keyboard, _player.player, _player.Speed);
    }
    public void InvokeRotate()
    {

        _playerMovment.Rotate( _inputs.X_Mouse, _player.RotationPoint, _player.Rotation);
    }
    public void InvokeRotateCam()
    {

        _playerMovment.RotateCam(-_inputs.Y_Mouse, _player.Cam_Place, _player.Rotation);
    }
}
