using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    public GameObject pauseMenu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            hideOrShow();

    }

    public void hideOrShow()
    {
        if (pauseMenu.activeInHierarchy == true)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 1;
        }
    }

    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void quit()
    {
        //Application.LoadLevel("nameOfMainMenu");
        Application.Quit();
    }
}
