using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment
{
    public void Jump(Rigidbody rb, float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
    }

    public void Move(float z, float x, GameObject gameObject,float speed)
    {
        gameObject.transform.position += new Vector3(x, 0, z)*Time.deltaTime* speed;
    }
    public void Rotate(float y, GameObject gameObject,float rotation)
    {
        gameObject.transform.Rotate( new Vector3(0, y, 0) * Time.deltaTime * rotation);
    }
    public void RotateCam( float x, GameObject gameObject, float rotation)
    {
        gameObject.transform.Rotate(new Vector3(x, 0, 0) * Time.deltaTime * rotation);
    }
}
