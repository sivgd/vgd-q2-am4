﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSentry : MonoBehaviour
{
    public Sprite check;
    public Sprite cross;
    public GameObject basic;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (basic.GetComponent<BallThrow>().active == true)
        {
            GetComponent<SpriteRenderer>().sprite = check;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = cross;
        }
    }
}
