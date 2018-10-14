using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineSpawner : MonoBehaviour {

    public GameObject fl;
    public float timeTillSpawn = 5.0f;
    public bool finishLineHasSpawned = false;

    // Use this for initialization
    void Start () 
    {

    }

    void Update() {
        // If the game is over, stop scrolling.
    }

    void FixedUpdate () {
        
        if (Time.time > timeTillSpawn && GameController.instance.gameOver == false && finishLineHasSpawned == false) 
        {
            Instantiate (fl, transform.position, transform.rotation);
            finishLineHasSpawned = true;
        }
	}

    // Create collider function that checks for player collision
}
