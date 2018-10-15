using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineSpawner : MonoBehaviour {

    public GameObject fl;
    public float timeTillSpawn = 5.0f;
    public bool finishLineHasSpawned = false;

    void FixedUpdate () {
        
        if (Time.time > timeTillSpawn && GameController.instance.gameOver == false && finishLineHasSpawned == false) 
        {
            Instantiate (fl, transform.position, transform.rotation);
            finishLineHasSpawned = true;

            // This is a message from Thomas 
        }
	}
}
