using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    // Start is called before the first frame update
    public void PressButtom()
    {
        Cliente.Instance.CreateObject();
       
    }
}
