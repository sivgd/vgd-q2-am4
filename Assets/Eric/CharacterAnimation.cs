using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            animator.SetBool("Hold", true);
            animator.SetBool("Thrown", false);
        }
        else if(GameObject.Find("snow").GetComponent<BallThrow>().thrown == true || GameObject.Find("MultNord").GetComponent<BallThrow>().thrown == true || GameObject.Find("MultMid").GetComponent<BallThrow>().thrown == true || GameObject.Find("MultSud").GetComponent<BallThrow>().thrown == true || GameObject.Find("bigSnow(k)").GetComponent<BallThrow>().thrown == true)
        {
            animator.SetBool("Hold", false);
            animator.SetBool("Thrown", true);
        }
        else if (GameObject.Find("snow").GetComponent<BallThrow>().thrown == false || GameObject.Find("MultNord").GetComponent<BallThrow>().thrown == false || GameObject.Find("MultMid").GetComponent<BallThrow>().thrown == false || GameObject.Find("MultSud").GetComponent<BallThrow>().thrown == false || GameObject.Find("bigSnow(k)").GetComponent<BallThrow>().thrown == false)
        {
            animator.SetBool("Hold", false);
            animator.SetBool("Thrown", false);
        }
    }
}
