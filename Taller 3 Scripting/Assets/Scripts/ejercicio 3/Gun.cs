using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private float force;

    public static int counter=0;
    public static bool canShoot = true;
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && canShoot== true)
        {
            Shoot();
        }
        else if (Input.GetMouseButtonDown(1))
        {
           
            counter++;
            if (counter>=3)
            {
                counter = 1;
            }
        }
    }

    private void Shoot()
    {
        Rigidbody bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = transform.position;
        bullet.AddForce(transform.forward * force);

    }
}
