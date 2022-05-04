using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciclar2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        BulletPool.Instance.ReleaseBullet(gameObject.GetComponent<Rigidbody>());
        Gun.canShoot = false;
        Invoke("BackTrue", 5f);
            
    }

    private void BackTrue() {
        Gun.canShoot = true;
    }
}
