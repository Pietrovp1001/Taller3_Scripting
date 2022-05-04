using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool2 : MonoBehaviour
{
    public GameObject GetBullet()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeInHierarchy)
            {
                return transform.GetChild(i).gameObject;
            }
        }
        return null;
    }
}
