using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuger : MonoBehaviour
{
    void Start()
    {
        Clicker.Instance.OnClick += DebugNumber;
    }
    private void DebugNumber(int number)
    {
        Debug.Log(number);
    }
}
