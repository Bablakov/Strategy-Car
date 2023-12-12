using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingsPanel;

    [System.Obsolete]
    public void PlayGame()
    {
        Application.LoadLevel("GameScene");
    }

    public void ExitGame()
    {
        Debug.Log("Game Over");
        Application.Quit();
    }

    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}
