using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float obstacleSpeed = -0.5f;

	// Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision (8,9);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate ()
    {

        rb2d.velocity = new Vector2 (0, GameController.instance.scrollSpeed);

        if(GameController.instance.gameOver == true)
        {
            Debug.Log (GameController.instance.gameOver);
            rb2d.velocity = Vector2.zero;
        }
    }
}