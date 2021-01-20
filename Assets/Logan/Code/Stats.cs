using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
    public int killreq;
    public Image health;
    public int unlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (GameObject.Find("Unity Sucks").GetComponent<Variables>().killCount >= killreq)
        {
            PlayerPrefs.SetInt("endless", 1);
            SceneManager.LoadScene("Victory");
        }

        health.fillAmount = currentHP / maxHP;   
    }
}
