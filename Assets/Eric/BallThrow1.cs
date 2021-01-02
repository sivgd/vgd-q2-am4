using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBallThrow : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float scale;
    public bool thrown = false;
    public Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseUp()
    {
        if (thrown == false)
        {
            rb2.gravityScale = 1;

            rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
            thrown = true;
        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            rb2.gravityScale = 0;
            thrown = false;
            rb2.velocity = new Vector3(0, 0, 0);
            transform.position = initialPos;
        }
    }
}
