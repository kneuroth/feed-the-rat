using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackActions
{
    private Snack snack;

    public SnackActions(Snack snack)
    {
        this.snack = snack;
    }
    

    public void Move(Transform transform, Transform ratTransform)
    {
        
        snack.Stats.Direction = (ratTransform.position - transform.position).normalized;
        Debug.DrawRay(transform.position, snack.Stats.Direction, Color.green);

        snack.RigidBody.velocity = new Vector2(snack.Stats.Direction.x * snack.Stats.Speed * Time.deltaTime, snack.Stats.Direction.y * snack.Stats.Speed * Time.deltaTime);
    }
}
