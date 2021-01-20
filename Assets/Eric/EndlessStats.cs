using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndlessStats : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
    public int killreq;
    public Image health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP == 0)
        {
            SceneManager.LoadScene("LevelScene");
        }
        else if (GameObject.Find("Unity Sucks").GetComponent<Variables>().killCount >= killreq)
        {
            //SceneManager.LoadScene("WinScene");
            print("Success!");
        }

        health.fillAmount = currentHP / maxHP;   
    }
}
