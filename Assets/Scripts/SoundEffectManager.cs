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

    [Header("Player Prefs")]
    public string PREF_SFXVOL = "sfxVol";
    public string PREF_SFXSTATUS = "sfxStatus";

    // untuk menghindari pembajakan, solusinya adalah jangan memberikan nama variabel sesuai dengan fungsinya. Misal bila ingin menyimpan highscore, jangan beri nama "highscore".
    

    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void InitiateSFX(){
        volumeSlider.value = audioSource.volume = PlayerPrefs.GetFloat("sfxVol", 0.5f);
        if(PlayerPrefs.GetInt(PREF_SFXSTATUS,1) == 1){
            isOn = true;
            soundBtnEffect.text = "Sound FX ON";
        }
        else{
            isOn = false;
            soundBtnEffect.text = "Sound FX OFF";
        }
    }

    public void ToogleSound(){
        if(isOn){
            isOn = false;
            audioSource.Stop();
            soundBtnEffect.text = "Sound FX OFF";
            PlayerPrefs.SetInt(PREF_SFXSTATUS,0);
        }
        else{
            isOn = true;
            soundBtnEffect.text = "Sound FX ON";
            PlayerPrefs.SetInt(PREF_SFXSTATUS,1);
        }
    }

    // Update is called once per frame
    public void SetVolume(){
        audioSource.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("sfxVol",audioSource.volume);
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
