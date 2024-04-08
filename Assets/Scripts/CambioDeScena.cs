using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeScena : MonoBehaviour
{

    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Play()
    {
        SceneManager.LoadScene("animales");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }


    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
