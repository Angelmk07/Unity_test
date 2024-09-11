using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (Rigidbody))]
public class Player : MonoBehaviour
{
    [field:SerializeField]
    public float Speed {  get; private set; }
    [field: SerializeField]
    public float Force {  get; private set; }
    [field: SerializeField]
    public float Rotation {  get; private set; }
    [field: SerializeField]
    public Rigidbody Rb { get; private set; }
    private void Awake()
    {
        Rb = GetComponent<Rigidbody>(); 
    }



}
