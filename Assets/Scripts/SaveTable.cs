using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTable : Collidable
{
    public SaveToDatabase save;
    public string message;
    public string savedMessage;

    private float cooldown = 4.0f;
    private float lastShout;

    protected override void Start()
    {
        base.Start();
        lastShout = -cooldown;
    }

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player" && Time.time-lastShout>cooldown)
        {
            lastShout = Time.time;
            GameManager.instance.ShowText(message, 25, Color.blue, transform.position + new Vector3(0, 0.16f, 0), Vector3.zero, cooldown);
        }
        if (coll.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            save.Start();
            SaveSystem.SavePlayer(GameManager.instance);
            GameManager.instance.ShowText(savedMessage, 35, Color.green, new Vector3(0, 0.16f, 0), Vector3.zero, 3f);
        }
    }
}
