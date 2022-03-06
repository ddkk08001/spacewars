using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject GameGroup;
    public GameObject SettingsGroup;
    public GameObject DebugMod;
    public GameObject MainMenuGroup;
    public GameObject GameGroupObject;

    void Start()
    {
        DebugMod.gameObject.SetActive(false);
        SettingsGroup.gameObject.SetActive(false);
        GameGroup.gameObject.SetActive(false);
        GameGroupObject.gameObject.SetActive(false);
        MainMenuGroup.gameObject.SetActive(true);
    }

    public void GameStart()
    {
        Debug.Log("GameStart!");
        MainMenuGroup.gameObject.SetActive(false);
        SettingsGroup.gameObject.SetActive(false);
        GameGroup.gameObject.SetActive(true);
        GameGroupObject.gameObject.SetActive(true);
    }

    public void Settings()
    {
        Debug.Log("Settings");
        MainMenuGroup.gameObject.SetActive(false);
        GameGroup.gameObject.SetActive(false);
        GameGroupObject.gameObject.SetActive(false);
        SettingsGroup.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
