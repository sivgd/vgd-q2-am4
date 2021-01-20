using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultCool : MonoBehaviour
{
    private float cooldownmax;
    private float cooldown;
    public float percent;

    // Start is called before the first frame update
    void Start()
    {
        cooldownmax = GameObject.Find("MultMid").GetComponent<BallThrow>().baseCooldown;

    }

    // Update is called once per frame
    void Update()
    {
        cooldown = GameObject.Find("MultMid").GetComponent<BallThrow>().cooldown;
        if (cooldown <= 0)
        {
            transform.localScale = new Vector3(5, 1, 1);
            GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        }
        else
        {
            percent = cooldown / cooldownmax;
            transform.localScale = new Vector3((5 - (5 * percent)), 1, 1);
            GetComponent<SpriteRenderer>().color = new Color((255 * percent), (255 - (255 * percent)), 0);
        }
    }
}
