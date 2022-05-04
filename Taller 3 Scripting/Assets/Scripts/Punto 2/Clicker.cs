using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clicker : MonoBehaviour
{
    private static Clicker instance;
    public static Clicker Instance
    {
        get
        {
            
            return instance;
        }
    }

    public event Action<int> OnClick;
    private int clickCount = 0;

    public int ClickCount
    {
        get
        {
            return clickCount;
        }
    }

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
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (clickCount >= 4)
            {
                clickCount = 1;
            }
            else clickCount++;

            OnClick(clickCount);
            
        }
    }
}
