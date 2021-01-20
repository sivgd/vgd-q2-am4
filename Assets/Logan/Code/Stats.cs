using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
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

        health.fillAmount = currentHP / maxHP;   
    }
}
