using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonRegreso : MonoBehaviour
{
    
    public void VolverEscenaPrincipal()
    {
        SceneManager.LoadScene("MainScene");
    }
}
