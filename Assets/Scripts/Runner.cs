using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public GameObject runnerGO;
    private Rigidbody2D rb2d;
    public float obstacleSpeed = -0.5f;
    public float speedAfterGathered;

    private Transform target;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision (13,8);
        Physics2D.IgnoreLayerCollision (13,12);

        target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
    }

    // Update is called once per frame
    void Update () {

    }

    void FixedUpdate ()
    {

        rb2d.velocity = new Vector2 (0, GameController.instance.scrollSpeed);

        if(GameController.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }


        if (GameController.instance.runnerGathered) 
        {
            Debug.Log ("Moving");
            transform.position = Vector2.MoveTowards (transform.position, target.position, speedAfterGathered);
        }
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            GameController.instance.runnerGathered = true;
            Debug.Log ("Triggered");
        }    
    }
}