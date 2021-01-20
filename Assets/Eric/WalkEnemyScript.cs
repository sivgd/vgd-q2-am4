using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkEnemyScript : MonoBehaviour
{
    public bool damaged = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((damaged == true && collision.gameObject.tag == "PlayerProjectile") | collision.gameObject.tag == "SuperPlayerProjectile")
        {
            GameObject.Find("Unity Sucks").GetComponent<Variables>().killCount++;
            Object.Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "PlayerProjectile")
        {
            damaged = true;
        }
    }
}
