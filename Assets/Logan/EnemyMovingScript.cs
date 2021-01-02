using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingScript : MonoBehaviour
{
    public float moveSpeed = 3;
    Transform EnemyWaypoint;
    Vector3 localScale;
    bool movingLeft = true;
    Rigidbody2D rb2;
    public GameObject EnemySpawner; 

    // Start is called before the first frame update
    void Start()
    {

        localScale = transform.localScale;
        rb2 = GetComponent<Rigidbody2D> ();
        EnemyWaypoint = GameObject.Find("EnemyWaypoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > EnemyWaypoint.position.x)
            movingLeft = true;

        if (movingLeft)
            moveLeft();

            
    }

    void moveLeft()
    {
        movingLeft = true;
        localScale.x = -1;
        transform.localScale = localScale;
        rb2.velocity = new Vector2(localScale.x * moveSpeed, rb2.velocity.y);
    }
}
