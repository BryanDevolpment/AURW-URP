using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ABKaspo.player.movement;
using ABKaspo.player.camera;

public class MenuManager : MonoBehaviour
{     
    public GameObject panelPause;
    public GameObject panelDebug;
    public GameObject panelEditor;
    public GameObject panelTextEditor;
    public FPSMovement fPSMovement;
    public FPSCamera fPSCamera;
    int tabMode = 0;
    void Update()
    {
        if (tabMode == 0)
        {
            panelEditor.SetActive(false);
            panelPause.SetActive(false);
            panelDebug.SetActive(false);
            panelTextEditor.SetActive(true);
            Time.timeScale = 1;
            fPSMovement.walk = 10.0f;
            fPSMovement.walk = 15.0f;
            fPSCamera.mouseSensivity = 80.0f;
            Cursor.lockState = CursorLockMode.Locked;
        }
        //
        if (Input.GetKeyDown(KeyCode.F2))
        {
            tabMode = 0;
        }
        //
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            tabMode = 1;
        }
        //
        if (Input.GetKeyDown(KeyCode.F3))
        {
            tabMode = 2;
        }
        //
        if (Input.GetKeyDown(KeyCode.C))
        {
            tabMode = 3;
        }
        //
        if (tabMode == 1)
        {
            panelEditor.SetActive(false);
            panelPause.SetActive(true);
            panelDebug.SetActive(false);
            panelTextEditor.SetActive(true);
            Time.timeScale = 0;
            fPSMovement.walk = 0;
            fPSMovement.walk = 0;
            fPSCamera.mouseSensivity = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
        //
        if (tabMode == 2)
        {
            panelEditor.SetActive(false);
            panelPause.SetActive(false);
            panelDebug.SetActive(true);
            panelTextEditor.SetActive(true);
            Time.timeScale = 1;
            fPSMovement.walk = 10.0f;
            fPSMovement.run = 15.0f;
            fPSCamera.mouseSensivity = 80.0f;
            Cursor.lockState = CursorLockMode.Locked;
        }
        //
        if (tabMode == 3)
        {
            panelEditor.SetActive(true);
            panelPause.SetActive(false);
            panelDebug.SetActive(false);
            panelTextEditor.SetActive(false);
            Time.timeScale = 1;
            fPSMovement.walk = 0;
            fPSMovement.walk = 0;
            fPSCamera.mouseSensivity = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void ResumeGame()
    {
        tabMode = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}