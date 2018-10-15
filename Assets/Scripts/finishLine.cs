using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour {

    Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb2d.velocity = new Vector2 (0, GameController.instance.scrollSpeed);

        if(GameController.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
	}

    // Hello Thomas if you see this then it worked
}
