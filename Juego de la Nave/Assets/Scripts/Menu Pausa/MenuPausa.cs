using UnityEngine;

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
}
