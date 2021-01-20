using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeScene : MonoBehaviour
{
    public int unlock;
    private void OnEnable()
    {
        unlock = 0;//PlayerPrefs.GetInt("endless");
    }
    public void btn_change_scene(string scene_name) 
    {
        if (scene_name == "MainLevel2")
        {
            if (unlock == 1)
            {
                SceneManager.LoadScene(scene_name);
            }
            else { SceneManager.LoadScene(scene_name); }
        }
        else
        {
            SceneManager.LoadScene(scene_name);
        }
    }

}
