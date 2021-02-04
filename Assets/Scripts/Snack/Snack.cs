using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snack : MonoBehaviour
{

    private Transform ratTransform;
    private GameObject rat;

    [SerializeField]
    private Rigidbody2D rigidBody;


    [SerializeField]
    private BoxCollider2D snackCollider;

    [SerializeField]
    private SnackStats stats;

    [SerializeField]
    private SnackComponents components;

    private SnackActions actions;

    public Rigidbody2D RigidBody { get => rigidBody; }
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

 
        rat = GameObject.Find("Rat");
        ratTransform = rat.transform;

        actions = new SnackActions(this);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject == rat)
        {
            Destroy(this.gameObject);
        }
    }



    private void FixedUpdate()
    {
        
        actions.Move(transform, ratTransform);
        
    }
}
