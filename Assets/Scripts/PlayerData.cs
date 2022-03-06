using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int health;
    public int pesos;
    public int experience;
    public int weaponLevel;
    public int gameQuality;
    public float musicVolume;
    public float[] position;
    public string currentScene;
    public float playedTime;

    public PlayerData (GameManager gameManager)
    {
        health = gameManager.player.hitpoint;
        pesos = gameManager.pesos;
        experience = gameManager.experience;
        weaponLevel = gameManager.weapon.weaponLevel;
        gameQuality = PlayerPrefs.GetInt("gameQuality");
        musicVolume = PlayerPrefs.GetFloat("musicVolume");
        currentScene = SceneManager.GetActiveScene().name;
        currentScene = gameManager.activeScene();
        playedTime = gameManager.playedTime+gameManager.recentlyPlayedTime;

        position = new float[3];
        position[0] = gameManager.player.transform.position.x;
        position[1] = gameManager.player.transform.position.y;
        position[2] = gameManager.player.transform.position.z;
    }

}
