using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    // obstacle field 
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMaxWait;
    public float spawnMinWait;
    public int startWait;
    int enemyNumber;

    void Start ()
    {
        
    }

    void Update () 
    {
        enemyNumber = Random.Range (0, 6);

        // randomizing spawn position
        Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), transform.position.y, transform.position.z);

        if (Time.time >= spawnWait && Time.time > startWait && GameController.instance.gameOver == false) 
        {
            Instantiate (enemies [enemyNumber], spawnPosition, transform.rotation);
            spawnWait = Time.time + Random.Range (spawnMinWait, spawnMaxWait);;
        }
    }

    void OnBecameInvisible()
    {
        Destroy (gameObject);
    }
}
