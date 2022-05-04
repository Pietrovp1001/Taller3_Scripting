using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Clicker.Instance.OnClick += CambiaColor;
    }

    // Update is called once per frame
    private void CambiaColor(int numero)
    {
        Renderer color = gameObject.GetComponent<Renderer>();
        color.material.color = RandomColor();

    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        Color color = new Color(r, g, b,1f);
        return color;

    }
    
}
