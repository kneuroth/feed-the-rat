using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snack : MonoBehaviour
{

    /* Snack references */
    private Transform ratTransform;
    public Transform RatTransform { get => ratTransform; }

    private GameObject rat;

    /* Snack components*/
    [SerializeField]
    private Rigidbody2D rigidBody;
    public Rigidbody2D RigidBody { get => rigidBody; }

    [SerializeField]
    private BoxCollider2D snackCollider;

    private Vector2 screenBounds;

    /* Snack Scripts */
    [SerializeField]
    private SnackStats stats;
    public SnackStats Stats { get => stats; }

    private SnackActions actions;
    public SnackActions Actions { get => actions; }




    


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
