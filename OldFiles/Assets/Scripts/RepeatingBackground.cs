using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private float groundVerticalLength = 10f;
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -groundVerticalLength)
            RepositionBackground ();
	}

    private void RepositionBackground() {
        Vector2 groundOffset = new Vector2(0, groundVerticalLength * 2f);

        transform.position = (Vector2) transform.position + groundOffset;
    }
}
