using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    CharacterMenu menu;
    GameObject HUD;
    GameManager gameManager;
    
    public void Awake()
    {
        GameObject.Find("HUD").SetActive(false);
        //menu.enabled = false;
    }

    public void PlayGame()
    {
        
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
