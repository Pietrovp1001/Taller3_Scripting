using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cliente : MonoBehaviour
{
    [SerializeField]
    private ObjectFactory factory;
    [SerializeField]
    private GameObject lastObject;

    int contador = 0;

    private static Cliente instance;

    public static Cliente Instance
    {
        get
        {
            
            return instance;
        }
    }

    //public event Action OnButtom;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void InvocarObjeto()
    {
        CreateObject();
        
    }

    public void CreateObject()
    {
        
        if (contador >= 3) contador = 0;
        if (lastObject != null)
            Destroy(lastObject);
        if (contador == 0) lastObject = factory.BuildCubo();
        else if (contador == 1) lastObject = factory.BuildEsfera();
        else if (contador == 2) lastObject = factory.BuildCapsula();

        contador++;
        lastObject.transform.position = new Vector3(948, 525, 0);
    }



}
