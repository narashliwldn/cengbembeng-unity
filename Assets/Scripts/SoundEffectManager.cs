using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffectManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundEffectManager Instance;
    AudioSource audioSource;
    public Text soundBtnEffect;
    public Slider volumeSlider;
    public bool isOn;
    
    [Header("Area Audio Clip")]
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    

    
    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void ToogleSound(){
        if(isOn){
            isOn = false;
            audioSource.Stop();
            soundBtnEffect.text = "Sound FX OFF";
        }
        else{
            isOn = true;
            soundBtnEffect.text = "Sound FX ON";
        }
    }

    // Update is called once per frame
    public void SetVolume(){
        audioSource.volume = volumeSlider.value;
    }

    public void PlaySound(AudioClip clip){
        if(isOn)
            audioSource.PlayOneShot(clip);
    }

    public void PlayButtonSFX(){
        PlaySound(clip3);
    }

    public void PlayCorrectSFX(){
        PlaySound(clip1);
    }

    public void PlayWrongSFX(){
        PlaySound(clip2);
    }
}
