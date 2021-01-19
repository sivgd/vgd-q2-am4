using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public SliderJoint2D volumeSlider; 
    
    
    
    
    public void SetLevel (float sliderValue)
    {

        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

   

}   


