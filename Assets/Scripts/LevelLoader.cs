using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    
    public void LoadLevel()
    {
        GameObject.Find("MainMenu").SetActive(false);
        GameObject.Find("Background").SetActive(false);
        StartCoroutine(LoadAsynchronously(PlayerPrefs.GetString("mentes")));
    }

    IEnumerator LoadAsynchronously (string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
}