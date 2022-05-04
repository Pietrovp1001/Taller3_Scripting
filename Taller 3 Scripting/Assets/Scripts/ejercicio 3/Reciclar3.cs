using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciclar3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        BulletPool.Instance.ReleaseBullet(gameObject.GetComponent<Rigidbody>());
        Debug.Log("Deberia ir un efecto");
    }

}
