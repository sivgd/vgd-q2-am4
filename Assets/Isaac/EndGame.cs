using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("has quit game");
        Application.Quit();

    }
}
