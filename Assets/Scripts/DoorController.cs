using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private DoorTrigger doorTrigger;
    [SerializeField] private BossBattleTrigger bossBattleTrigger;
    public List<Sprite> doorSkins;
    public List<Sprite> pressureplateSkin;
    public SpriteRenderer spriteRenderer;
    public GameObject doorBlock;

    private void Start()
    {
        doorTrigger.DoorEventTrigger += DoorTrigger_DoorEventTrigger;
        bossBattleTrigger.OnplayerEnterTrigger += BossBattleTrigger_OnPlayerEntertrigger;
    }

    private void BossBattleTrigger_OnPlayerEntertrigger(object sender, EventArgs e)
    {
        doorBlock.SetActive(true);
        spriteRenderer.sprite = doorSkins[0];
        doorTrigger.spriteRenderer.sprite = pressureplateSkin[0];
        bossBattleTrigger.OnplayerEnterTrigger -= BossBattleTrigger_OnPlayerEntertrigger;
    }

    private void DoorTrigger_DoorEventTrigger(object sender, EventArgs e)
    {
        Debug.Log("door opened");
        doorTrigger.spriteRenderer.sprite = pressureplateSkin[1];
        spriteRenderer.sprite = doorSkins[1];
        doorBlock.SetActive(false);
        doorTrigger.DoorEventTrigger -= DoorTrigger_DoorEventTrigger;
    }
}
