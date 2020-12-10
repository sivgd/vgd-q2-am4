using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float tx;
    public float ty;//throwx+y

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        rb2.gravityScale = 1;
        rb2.AddForce(new Vector2(tx, ty));
    }
}
