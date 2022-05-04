using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciclar : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        BulletPool.Instance.ReleaseBullet(gameObject.GetComponent<Rigidbody>());
        Debug.Log("No se pudo con este punto :c");
    }
}
