using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GetDataFromDatabase : MonoBehaviour
{
    public int health;
    public int pesos;
    public int experience;
    public int weaponLevel;
    public int gameQuality;
    public float musicVolume;
    public string currentScene;
    public float playedTime;

    public void Awake()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        WWWForm form = new WWWForm();
        form.AddField("id", PlayerPrefs.GetString("playerID"));
        UnityWebRequest www = UnityWebRequest.Post("http://192.168.31.20:8080/DungeonGame/GetDataFromDatabase.php",form);
        yield return www.SendWebRequest();

        if (www.downloadHandler.text[0] == 'E')
        {
            Debug.Log(www.downloadHandler.text);
        }
        else
        {
            string s = www.downloadHandler.text;
            health = int.Parse(s.Split('-')[0]);
            pesos = int.Parse(s.Split('-')[1]);
            experience = int.Parse(s.Split('-')[2]);
            weaponLevel = int.Parse(s.Split('-')[3]);
            gameQuality = int.Parse(s.Split('-')[6]);
            musicVolume = float.Parse(s.Split('-')[7]);
            currentScene = s.Split('-')[5];
            playedTime = float.Parse(s.Split('-')[4]);
        }
    }
}