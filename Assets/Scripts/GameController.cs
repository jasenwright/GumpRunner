using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public static GameController instance;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public bool runnerGathered = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy (gameObject);
    }
}

