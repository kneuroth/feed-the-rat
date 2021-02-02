using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snack : MonoBehaviour
{

    [SerializeField]
    private Transform ratTransform;

    [SerializeField]
    private SnackStats stats;

    [SerializeField]
    private SnackComponents components;

    private SnackActions actions;

    public SnackComponents Components { get => components; }
    public SnackStats Stats { get => stats; }
    public SnackActions Actions { get => actions; }
    public Transform RatTransform { get => ratTransform; }


    // Start is called before the first frame update
    private void Start()
    {
        
    }

   

    private void Awake()
    {
        



        

        actions = new SnackActions(this);
        
        //stats.Direction = new Vector2(0,-1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void FixedUpdate()
    {

        
        actions.Move(transform, ratTransform);
    }
}
