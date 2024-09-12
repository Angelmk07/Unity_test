using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment
{
    public void Jump(Rigidbody rb, float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    public void Move(float z, float x, GameObject gameObject,float speed)
    {
        gameObject.transform.position += new Vector3(x, 0, z)*Time.deltaTime* speed;
    }
    public void Rotate(float y, float x, GameObject gameObject,float rotation)
    {
        gameObject.transform.position += new Vector3(x, y, 0) * Time.deltaTime * rotation;
    }
}
