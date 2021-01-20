using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessDeadzoneDamage : MonoBehaviour
{
    public EndlessStats player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.currentHP -= 10;
        Destroy(collision.gameObject);
    }

}
