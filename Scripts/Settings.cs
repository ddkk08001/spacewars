using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject GameGroup;
    public GameObject SettingsGroup;
    public GameObject MainMenuGroup;
    public GameObject GameGroupObject;

    public void BacktoMenu()
    {
        GameGroup.gameObject.SetActive(false);
        SettingsGroup.gameObject.SetActive(false);
        GameGroupObject.gameObject.SetActive(false);
        MainMenuGroup.gameObject.SetActive(true);
    }
}
