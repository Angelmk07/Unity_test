using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLisener : MonoBehaviour
{
    float z;
    float x;
    bool _IsJump;
    void Update()
    {
        ReadJumpInput();
        ReadHorizontalInput();
        ReadVerticalInput();
    
    }
    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _IsJump= true;
        }
    }
    private void ReadHorizontalInput()
    {
         x = Input.GetAxis("Horizontal");
    }
    private void ReadVerticalInput()
    {
         z = Input.GetAxis("Vertical");
    }
}
