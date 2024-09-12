using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLisener : MonoBehaviour
{
    PlayerInvoker _playerInvoker;
    PlayerMovment _playerMovment;
    PlayerShoot _playerShoot;
    InputLisener _inputLisener;
    [SerializeField]
    Player _player;
    private bool _canMove = true;
    private bool _canJump = true;
    public float Z_Keyboard { get; private set; }
    public float X_Keyboard { get; private set; }
    public bool IsJump { get; private set; }
    public float Y_Mouse { get; private set; }
    public float X_Mouse { get; private set; }
    private void Awake()
    {
        _playerMovment = new();
        _playerShoot = new();
        _inputLisener = GetComponent<InputLisener>();
        _playerInvoker = new PlayerInvoker(_playerMovment, _playerShoot, _player, _inputLisener);
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
        StopInput();
        ReadShootInput();
        }
        ReturnInput();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            _canJump = true;
        }
    }
    private void StopInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _canMove = false;
            _player.tmp.color = Color.red;
            _player.tmp.text = "Not use input";
            
        }
    }
    private void ReturnInput()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _canMove = true;
            _player.tmp.color = Color.green;
            _player.tmp.text = "Use input";

        }


        
    }
    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)||_canJump)
        {
            _playerInvoker.InvokeJump();
            _canJump = false;
        }
    }
    private void ReadShootInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerInvoker.InvokeShoot();

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
