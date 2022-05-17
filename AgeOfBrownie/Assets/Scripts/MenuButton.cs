using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void toMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void toStart()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void toNext()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void toExit()
    {
        Application.Quit();
    }
}
