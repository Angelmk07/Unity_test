using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLisener : MonoBehaviour
{
    PlayerInvoker _playerInvoker;
    PlayerMovment _playerMovment;
    InputLisener _inputLisener;
    [SerializeField]
    Player _player;
    private bool _canMove = true;
    public float Z_Keyboard { get; private set; }
    public float X_Keyboard { get; private set; }
    public bool IsJump { get; private set; }
    public float Y_Mouse { get; private set; }
    public float X_Mouse { get; private set; }
    private void Awake()
    {
        _playerMovment = new();
        _inputLisener = GetComponent<InputLisener>();
        _playerInvoker = new PlayerInvoker(_playerMovment, _player, _inputLisener);
    }
    void Update()
    {
        if (_canMove)
        {
        ReadJumpInput();
        ReadHorizontalInput();
        ReadVerticalInput();
        ReadMouseX();
        ReadMouseY();
        _playerInvoker.InvokeRotate();
        _playerInvoker.InvokeMove();
        _playerInvoker.InvokeRotateCam();
        }

    }
    private void StopInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _canMove = false;
        }
    }
    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerInvoker.InvokeJump();
        }
    }
    private void ReadHorizontalInput()
    {
        Z_Keyboard = Input.GetAxis("Horizontal");
    }
    private void ReadVerticalInput()
    {
        X_Keyboard = Input.GetAxis("Vertical");
    }
    private void ReadMouseX()
    {
        X_Mouse = Input.GetAxis("Mouse X");
    }
    private void ReadMouseY()
    {
        Y_Mouse = Input.GetAxis("Mouse Y");
    }
}
