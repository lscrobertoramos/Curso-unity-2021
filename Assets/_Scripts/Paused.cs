using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Paused : MonoBehaviour
{
    public GameObject pausedMenu;
    public Button exitButton;

    private void Awake()
    {
        pausedMenu.SetActive(false);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            pausedMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        
        pausedMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void ExitGame()
    {
        print("Ejecución finalizada");
        Application.Quit();
    }
}
