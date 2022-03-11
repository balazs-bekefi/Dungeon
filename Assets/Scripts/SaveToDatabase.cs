using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;
using UnityEngine.Networking;
using System;

public class SaveToDatabase : MonoBehaviour
{
    
    /*public void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        string id = PlayerPrefs.GetString("playerID");
        int pesos = data.pesos;
        int experience = data.experience;
        int weaponlevel = data.weaponLevel;
        int health = data.health;
        string playedTime = data.playedTime.ToString("0.0000");
        string musicVolume = PlayerPrefs.GetFloat("musicVolume").ToString("0.0000");
        int gamequality=PlayerPrefs.GetInt("gameQuality");
        string lastscene = PlayerPrefs.GetString("lastScene");
        StartCoroutine(AddData(id,pesos,experience,weaponlevel,health,playedTime,musicVolume,gamequality,lastscene));
    }*/

    public void Save()
    {
        
        PlayerData data = SaveSystem.LoadPlayer();
        string id = PlayerPrefs.GetString("playerID");
        int pesos = GameManager.instance.pesos;
        int experience = GameManager.instance.experience;
        int weaponlevel = GameManager.instance.weapon.weaponLevel;
        int health = GameManager.instance.player.hitpoint;
        float fullplayedTime = GameManager.instance.playedTime + GameManager.instance.recentlyPlayedTime;
        string playedTime = fullplayedTime.ToString("0.0000");
        string musicVolume = PlayerPrefs.GetFloat("musicVolume").ToString("0.0000");
        int gamequality = PlayerPrefs.GetInt("gameQuality");
        string lastscene = SceneManager.GetActiveScene().name;
        StartCoroutine(AddData(id, pesos, experience, weaponlevel, health, playedTime, musicVolume, gamequality, lastscene));
    }

    IEnumerator AddData(string id,int pesos,int experience,int weaponlevel,int health,string playedTime,string musicVolume,int gamequality,string lastscene)
    {
        WWWForm form = new WWWForm();
        form.AddField("id", id);
        form.AddField("health", health);
        form.AddField("pesos", pesos);
        form.AddField("experience", experience);
        form.AddField("weaponlevel", weaponlevel);
        form.AddField("playedtime", playedTime);
        form.AddField("lastscene", lastscene);
        form.AddField("gamequality", gamequality);
        form.AddField("musicvolume", musicVolume);

        UnityWebRequest www = UnityWebRequest.Post("https://adungeongame.000webhostapp.com/SavePlayerData.php", form);
        yield return www.SendWebRequest();
        if (www.downloadHandler.text[0] == '0')
        {
            Debug.Log("Sikeresen feltöltve");
        }
        else
        {
            SaveSystem.SavePlayer(GameManager.instance);
        }

    }
}
