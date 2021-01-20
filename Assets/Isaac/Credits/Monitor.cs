using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monitor : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.C))
        {

            SceneManager.LoadScene("CreditRoller"); //Requires "Using" (see above)

        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            SceneManager.LoadScene("MainLevel1"); //Requires "Using" (see above)

        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            SceneManager.LoadScene("MainLevel2"); //Requires "Using" (see above)

        }

        if (Input.GetKeyDown(KeyCode.O))
        {

            SceneManager.LoadScene("MainMenu"); //Requires "Using" (see above)

        }




    }
}
