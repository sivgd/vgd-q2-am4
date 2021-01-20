using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessEnemySpawnerScript : MonoBehaviour
{

    public GameObject flyingenemy;
    public GameObject groundenemy;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    public float nextFlyingSpawn = 0.0f;
    public float nextGroundSpawn = 1f;
    public float startTime;
    public float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed = Time.time - startTime;
        if(timeElapsed/60 >= 3.25)
        {
            spawnRate = 0.75f;
        }
        else
        {
            spawnRate = 3 - (timeElapsed / 60);
        }
        //print(Time.time);
        if (Time.time > nextFlyingSpawn)
        {
            nextFlyingSpawn = Time.time + spawnRate;
            randY = Random.Range(3, -1);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(flyingenemy, whereToSpawn, Quaternion.identity);
        }

        if (Time.time > nextGroundSpawn)
        {
            nextGroundSpawn = Time.time + spawnRate * 2;
            randY = Random.Range(1, -1);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(groundenemy, whereToSpawn, Quaternion.identity);
        }
    }
}
