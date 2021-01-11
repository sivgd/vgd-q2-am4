using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tes : MonoBehaviour
{
    public GameObject snowballProjectile;
    public GameObject player;
    private Vector2 velocity = Vector2.zero;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PublicStaticVars.enemiesHit == 10)
        {
            SceneManager.LoadScene("End");
        }


        if (Input.GetMouseButtonDown(0))
        {
            PublicStaticVars.worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Instantiate(snowballProjectile, new Vector3(player.transform.position.x + .75f, player.transform.position.y + 2f, 0), Quaternion.identity);

            Instantiate(snowballProjectile, new Vector3(player.transform.position.x + 1f, player.transform.position.y + 2.5f, 0), Quaternion.identity);

            Instantiate(snowballProjectile, new Vector3(player.transform.position.x + 1.25f, player.transform.position.y + 3f, 0), Quaternion.identity);
        }
    }




    //Script needs to be on the snowball
    void update()
    {
        gameObject.transform.position = Vector2.SmoothDamp(gameObject.transform.position, PublicStaticVars.worldPoint, ref velocity, .15f, Mathf.Infinity, Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PublicStaticVars.enemiesHit++;
        }
    }


}
