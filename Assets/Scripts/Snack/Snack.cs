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

    private Vector2 screenBounds;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

   

    private void Awake()
    {





        ratTransform = GameObject.Find("Rat").transform;
        actions = new SnackActions(this);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
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
