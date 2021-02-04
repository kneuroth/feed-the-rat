using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /* Player references */
    [SerializeField]
    public GameObject snackPrefab;
    public GameObject SnackPrefab { get => snackPrefab; }

    /* Player components */
    [SerializeField]
    private Rigidbody2D rigidBody;
    public Rigidbody2D RigidBody { get => rigidBody; }

    /* Player scripts */
    [SerializeField]
    private PlayerStats stats;
    public PlayerStats Stats { get => stats; }

    private PlayerActions actions;
    public PlayerActions Actions { get => actions; }

    private PlayerUtilities utilities;
   

    private void Awake()
    {
        actions = new PlayerActions(this);
        utilities = new PlayerUtilities(this);
        stats.Speed = stats.WalkSpeed;
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        utilities.HandleInput();
    }

    private void FixedUpdate()
    {
        actions.Move(transform);
    }
}
