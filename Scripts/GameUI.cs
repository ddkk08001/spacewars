using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject GameGroup;
    public GameObject SettingsGroup;
    public GameObject DebugMod;
    public GameObject MainMenuGroup;
    public GameObject GameGroupObject;
    public GameObject BetaInfoUI;

    public void BacktoMenu()
    {

        SettingsGroup.gameObject.SetActive(false);
        BetaInfoUI.gameObject.SetActive(false);
        GameGroupObject.gameObject.SetActive(false);
        MainMenuGroup.gameObject.SetActive(true);
        GameGroup.gameObject.SetActive(false);
    }
}
