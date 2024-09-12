using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed => speed;
    public Rigidbody Rb => rb;

    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody rb;
    private void OnEnable()
    {
        StartMove();
    }
    private void StartMove()
    {
        Debug.Log("AddForce");
        rb.AddForce(gameObject.transform.forward * speed, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
