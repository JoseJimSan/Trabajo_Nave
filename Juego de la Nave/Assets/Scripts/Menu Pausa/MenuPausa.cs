using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Panel;

    private bool inPause;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape ))
            inPause=!inPause;
        if(inPause)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Panel.SetActive(false);
        }
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
    }
    public void Resetear()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CambioEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
