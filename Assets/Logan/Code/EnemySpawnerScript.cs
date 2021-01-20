using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject flyingenemy;
    public GameObject groundenemy;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextFlyingSpawn = 0.0f;
    float nextGroundSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > nextFlyingSpawn)
        {
            nextFlyingSpawn = Time.time + spawnRate;
            randY = Random.Range(5, -1);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(flyingenemy, whereToSpawn, Quaternion.identity);
        }

        if (Time.time > nextGroundSpawn)
        {
            nextGroundSpawn = Time.time + spawnRate * 2;
            randY = Random.Range(-2, -3);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(groundenemy, whereToSpawn, Quaternion.identity);
        }
    }
}
