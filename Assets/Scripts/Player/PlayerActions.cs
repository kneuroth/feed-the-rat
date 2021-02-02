using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{

    private Player player;

    public PlayerActions(Player player)
    {
        this.player = player;
    }

    public void Move(Transform transform)
    {
        player.Components.RigidBody.velocity = new Vector2(player.Stats.Direction.x * player.Stats.Speed * Time.deltaTime, y: player.Stats.Direction.y);
    }
}
