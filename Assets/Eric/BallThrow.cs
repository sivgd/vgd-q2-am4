﻿using System.Collections;
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
        if (GameObject.Find("MultMid").GetComponent<BallThrow>().thrown == false && GameObject.Find("snow").GetComponent<BallThrow>().thrown == false && GameObject.Find("bigSnow(k)").GetComponent<BallThrow>().thrown == false)
        {
            /*if (cooldown > 0 && isBasic == false)
            {
                active = false;
                GameObject.Find("snow").GetComponent<BallThrow>().active = true;
                print("switch to one");
            }
            else
            {*/
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
               //}
        }
        if (active == false | thrown == false)
        {
            gameObject.layer = 8;
            col.enabled = false;
            rb2.simulated = false;
        }
        else
        {
            gameObject.layer = 0;
            col.enabled = true;
            rb2.simulated = true;
        };
        if (Input.GetKeyUp(KeyCode.Mouse0) == true && thrown == false && active == true && cooldown < 0)
        {
            gameObject.layer = 0;
            col.enabled = true;
            rb2.simulated = true;
            rb2.gravityScale = 1;
            thrown = true;
            cooldown = baseCooldown;
            if (gameObject.name == "MultNord")
            {
                rb2.AddForce(scale * ((downspeed + Camera.main.ScreenToWorldPoint(Input.mousePosition)) - transform.position));
                rb2.AddTorque(-1);
            }
            else if (gameObject.name == "MultSud")
            {
                rb2.AddForce(scale * ((upspeed + Camera.main.ScreenToWorldPoint(Input.mousePosition)) - transform.position));
                rb2.AddTorque(-1);
            }
            else if (gameObject.name == "MultMid")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
                rb2.AddTorque(-1);
            }
            else if (gameObject.name == "snow")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
                rb2.AddTorque(-1);
            }
            else if (gameObject.name == "bigSnow(k)")
            {
                rb2.AddForce(scale * (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
                rb2.AddTorque(-1);
            }
            
        }
        if(active == false && thrown == true)
        {
            rb2.gravityScale = 0;
            thrown = false;
            rb2.velocity = new Vector3(0, 0, 0);
            rb2.angularVelocity = 0;
            transform.position = initialPos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2.gravityScale = 0;
        thrown = false;
        rb2.velocity = new Vector3(0, 0, 0);
        rb2.angularVelocity = 0;
        transform.position = initialPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb2.gravityScale = 0;
        thrown = false;
        rb2.velocity = new Vector3(0, 0, 0);
        rb2.angularVelocity = 0;
        transform.position = initialPos;
    }
}
