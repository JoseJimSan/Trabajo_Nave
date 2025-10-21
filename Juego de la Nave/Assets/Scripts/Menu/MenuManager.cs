using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void CambioEscena(string nombreEscena)
    { 
        SceneManager.LoadScene(nombreEscena);
    }
    public void Salir()
    {
        Application.Quit();
    }
}