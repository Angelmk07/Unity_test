using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [field: SerializeField]
    public GameObject player  { get; private set; }
    [field: SerializeField]
    public GameObject RotationPoint { get; private set; }
    [field: SerializeField]
    public GameObject Cam_Place { get; private set; }
    [field: SerializeField]
    public GameObject Cam { get; private set; }
    [field: SerializeField]
    public GameObject Hands { get; private set; }
    [field: SerializeField]
    public TextMeshProUGUI tmp { get; private set; }
    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
        player = gameObject;
        Cam = Camera.main.gameObject;


    }



}
