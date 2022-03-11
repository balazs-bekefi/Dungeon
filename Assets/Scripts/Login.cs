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
        WWW www =new WWW("https://adungeongame.000webhostapp.com/unitylogin.php", form);
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
            errorText.text = "Valami hiba t�rt�nt, pr�b�ld �jra k�s�bb!"+www.text;
        }
        
    }


    public void VeryfyInputs()
    {
        submitButton.interactable = passwordField.text.Length >= 6;
    }
}
