using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private float force;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Rigidbody bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = transform.position;
        bullet.AddForce(transform.forward * force);

    }
}
