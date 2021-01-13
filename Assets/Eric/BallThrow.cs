using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    private Rigidbody2D rb2;
    private CircleCollider2D col;
    public float scale;
    public bool thrown = false;
    public Vector3 initialPos;
    public bool active = false;
    public bool isBasic = true;
    public bool isMult = false;
    public bool isHeav = false;
    public Vector3 upspeed; //what's upspeed?
    public Vector3 downspeed;
    public float cooldown;
    public float baseCooldown;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (GameObject.Find("MultMid").GetComponent<BallThrow>().thrown == false && GameObject.Find("snow").GetComponent<BallThrow>().thrown == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) == true && isBasic == true)
            {
                active = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1) == true && isBasic == false)
            {
                active = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) == true && isMult == true)
            {
                active = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) == true && isMult == false)
            {
                active = false;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) == true && isHeav == true)
            {
                active = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) == true && isHeav == false)
            {
                active = false;
            }
        }
        if (active == false)
        {
            gameObject.layer = 8; //And now, for my disappearing trick!
            col.enabled = false;
            rb2.simulated = false;
        }
        else
        {
            gameObject.layer = 0; //You've found me!
            col.enabled = true;
            rb2.simulated = true;
        };
        if (Input.GetKeyUp(KeyCode.Mouse0) == true && thrown == false && active == true && cooldown <= 0)
        {
            rb2.gravityScale = 1;
            thrown = true;
            cooldown = baseCooldown;
            if(gameObject.name == "MultNord")
            {
                rb2.AddForce(scale * ((downspeed + Camera.main.ScreenToWorldPoint(Input.mousePosition)) - transform.position));
                GameObject.Find("Unity Sucks").GetComponent<Variables>().North = false;
            }
            else if(gameObject.name == "MultSud")
            {
                rb2.AddForce(scale * ((upspeed + Camera.main.ScreenToWorldPoint(Input.mousePosition)) - transform.position));
                GameObject.Find("Unity Sucks").GetComponent<Variables>().East = false;
            }
            else if (gameObject.name == "MultMid")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
                GameObject.Find("Unity Sucks").GetComponent<Variables>().South = false;
            }
            else if (gameObject.name == "snow")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
            }
            else if (gameObject.name == "bigSnow(k)")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
            }
        }
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
