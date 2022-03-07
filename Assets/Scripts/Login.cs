using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[System.Serializable]
public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Text errorText;
    public Button submitButton;


    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password1", passwordField.text);
        WWW www =new WWW("http://192.168.31.20:8080/dungeongame/unitylogin.php", form);
        yield return www;
        if (www.text[0]=='0')
        {
            string[] getID = www.text.Split('/');
            PlayerPrefs.SetString("playerID", getID[1]);
            PlayerPrefs.SetString("playerName", nameField.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
        }
        else
        {
            errorText.text = "Valami hiba történt, próbáld újra késöbb!";
        }
        
    }


    public void VeryfyInputs()
    {
        submitButton.interactable = passwordField.text.Length >= 6;
    }
}
