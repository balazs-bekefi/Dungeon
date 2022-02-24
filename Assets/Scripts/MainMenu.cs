using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        GameObject.Find("MainMenu").SetActive(false);
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.currentScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("gameQuality", qualityIndex);
    }
}
