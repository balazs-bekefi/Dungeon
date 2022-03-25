using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : Collidable
{
    public event EventHandler DoorEventTrigger;

    public SpriteRenderer spriteRenderer;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player" && DoorEventTrigger != null)
        {
            DoorEventTrigger?.Invoke(this, EventArgs.Empty);
        }
    }
}