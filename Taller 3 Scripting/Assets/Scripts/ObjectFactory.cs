using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    [SerializeField] 
    private GameObject _Cubo;

    [SerializeField]
    private GameObject _Esfera;

    [SerializeField]
    private GameObject _Capsula;

    public GameObject BuildCubo()
    {
        GameObject instance = Instantiate(_Cubo);
        return instance;
    }
    public GameObject BuildEsfera()
    {
        GameObject instance = Instantiate(_Esfera);
        return instance;
    }
    public GameObject BuildCapsula()
    {
        GameObject instance = Instantiate(_Capsula);
        return instance;
    }
}
