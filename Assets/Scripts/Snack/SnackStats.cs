using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SnackStats
{
    public Vector2 Direction { get; set; }

    public float Speed { get => speed; }

    [SerializeField]
    private float speed;
    
}
