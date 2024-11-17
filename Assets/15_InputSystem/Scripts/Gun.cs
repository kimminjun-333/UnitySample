using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shoot;

    public void BulletSoot()
    {
        Instantiate(bullet, shoot.transform.position, shoot.transform.rotation);
    }

}
