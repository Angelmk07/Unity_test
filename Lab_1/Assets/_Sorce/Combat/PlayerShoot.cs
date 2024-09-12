using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    GameObject instBullet;
    public void Shoot(GameObject prefub,GameObject startPoint, Vector3 vector)
    {
        instBullet = Instantiate(prefub,
           startPoint.transform.position,
           startPoint.transform.rotation);

    }

}
