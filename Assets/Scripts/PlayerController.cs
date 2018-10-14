using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject player;

    // private RandomRunners ranruns[];

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rb2d.velocity = (movement * speed);
	}

    // OnTriggerEnter2D is called whenever this object overlaps with a trigger collider
    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("Finish"))
            GameController.instance.gameOver = true;
    }
}
