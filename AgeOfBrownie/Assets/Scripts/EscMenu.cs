using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public GameObject escMenu;

    private bool paused = false;

    void Start()
    {
        escMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            escMenu.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            escMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
