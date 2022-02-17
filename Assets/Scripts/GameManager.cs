using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        SceneManager.sceneLoaded += LoadState;
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            Destroy(floatingTextManager.gameObject);
            Destroy(menu);
            Destroy(hud);
            Destroy(floatingTextManager);
            
            return;
        }
        instance = this;
        AudioListener.volume= PlayerPrefs.GetFloat("musicVolume");
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("gameQuality"));
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        OnHitpointChange();
    }

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;
    public Player player;
    public Weapon weapon;
    public FloatingTextManager floatingTextManager;
    public RectTransform hitpointBar;
    public Animator deathMenuAnim;
    public GameObject hud;
    public GameObject menu;

    public int pesos;
    public int experience;

    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    public bool TryUpgradeWeapon()
    {
        if (weaponPrices.Count <= weapon.weaponLevel)
            return false;

        if (pesos >= weaponPrices[weapon.weaponLevel])
        {
            pesos -= weaponPrices[weapon.weaponLevel];
            weapon.UpgradeWeapon();
            return true;
        }
        return false;
    }

    public void OnHitpointChange()
    {
        float ratio = (float)player.hitpoint / (float)player.maxHitpoint;
        hitpointBar.localScale = new Vector3(1, ratio, 1);
    }

    public int GetCurrentLevel()
    {
        int r = 0;
        int add = 0;

        while (experience >= add)
        {
            add += xpTable[r];
            r++;

            if (r == xpTable.Count)
                return r;
        }
        return r;
    }

    public int GetXpToLevel(int level)
    {
        int r = 0;
        int xp = 0;
        while (r < level)
        {
            xp += xpTable[r];
            r++;
        }
        return xp;
    }

    public void GrantXp(int xp)
    {
        int currLevel = GetCurrentLevel();
        experience += xp;
        if (currLevel < GetCurrentLevel())
            OnLevelUp();
    }

    public void OnLevelUp()
    {
        player.OnLevelUp();
        OnHitpointChange();
    }

    public void OnSceneLoaded(Scene s,LoadSceneMode mode)
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if (data.currentScene == SceneManager.GetActiveScene().name)
        {
            Debug.Log("if telejsül");
            player.transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);

        }
        else
        {
            player.transform.transform.position = GameObject.Find("SpawnPoint").transform.position;

        }
        hud.SetActive(true);
    }

    public void Respawn()
    {
        deathMenuAnim.SetTrigger("hide");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        player.Respawn();
    }

    public string activeScene()
    {
        return SceneManager.GetActiveScene().name;
    }

    
    public void LoadState(Scene s, LoadSceneMode mode)
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.sceneLoaded -= LoadState;

        Debug.Log(data.currentScene + " " + SceneManager.GetActiveScene().name);
        pesos = data.pesos;
        experience = data.experience;
        player.SetLevel(GetCurrentLevel());
        weapon.SetWeaponLevel(data.weaponLevel);
        player.hitpoint = data.health;

        if (data.currentScene == SceneManager.GetActiveScene().name)
        {
            Debug.Log("if telejsül");
            player.transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);

        }
        else
        {
            Debug.Log("if nem teljesül"+ GameObject.Find("SpawnPoint").transform.position.ToString("F4"));
           

        }
        
    }

}
