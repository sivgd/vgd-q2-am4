
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private int firstPlayInt;
    public SliderJoint2D backgroundSlider;
    private float backgroundFloat, soundEffectsFloat;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if(firstPlayInt == 0)
        {

        
        }
        else
        {

        }
    
    }

  
}
