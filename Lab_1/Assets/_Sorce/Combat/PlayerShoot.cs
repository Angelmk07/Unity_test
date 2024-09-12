using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public void Shoot(GameObject prefub,GameObject startPoint, Vector3 vector)
    {
       GameObject instBullet = Instantiate(prefub,
           startPoint.transform.position,
           startPoint.transform.rotation);
        instBullet.transform.LookAt(vector);
    }

}
