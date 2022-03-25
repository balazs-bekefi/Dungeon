using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBattle : MonoBehaviour
{
    [SerializeField] private BossBattleTrigger bossBattleTrigger;
    [SerializeField] private Enemy _EnemyPrefab;
    public GridManager gridManager;
    public GameObject canvas;
    public FinalBoss finalBoss;
    public GameObject doorBlock;
    private int count=0;

    private void Start()
    {
        bossBattleTrigger.OnplayerEnterTrigger += BossBattleTrigger_OnPlayerEntertrigger;        
    }

    private void BossBattleTrigger_OnPlayerEntertrigger(object sender, EventArgs e)
    {
        StartBattle();
        bossBattleTrigger.OnplayerEnterTrigger -= BossBattleTrigger_OnPlayerEntertrigger;
    }

    private void StartBattle()
    {
        canvas.SetActive(true);
        //gridManager.Call();
    }
    private void Update()
    {
        if (finalBoss.hitpoint < 50 && count==0)
        {
            SecondPhase();
        }       
    }
    private void SecondPhase()
    {
        count++;
        var spawnedTile = Instantiate(_EnemyPrefab, new Vector3(4.465555f, 0.6733211f, 0f), Quaternion.identity);
        spawnedTile.name = $"Enemy0";
        var spawnedTile1 = Instantiate(_EnemyPrefab, new Vector3(4.324427f, 0.2002443f, 0f), Quaternion.identity);
        spawnedTile1.name = $"Enemy1";
        var spawnedTile2 = Instantiate(_EnemyPrefab, new Vector3(4.307f, -0.365f, 0f), Quaternion.identity);
        spawnedTile2.name = $"Enemy2";
    }
}
