using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBattle : MonoBehaviour
{
    [SerializeField] private BossBattleTrigger bossBattleTrigger;
    public GridManager gridManager;
    public GameObject canvas;

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
        gridManager.Call();
    }
}
