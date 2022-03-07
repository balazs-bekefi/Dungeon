using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using UnityEngine.Networking;
using System;

public class SaveToDatabase : MonoBehaviour
{
    
    public void Start()
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

        UnityWebRequest www = UnityWebRequest.Post("http://192.168.31.20:8080/DungeonGame/SavePlayerData.php", form);
        yield return www.SendWebRequest();
        Debug.Log(www.downloadHandler.text);
        
    }
}
