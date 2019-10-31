using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;
    AudioSource audioSource;
    public Text musicBtnText;
    public AudioClip[] audioClips;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
       Instance = this;
       //ambil komponen audiosource. Tapi cukup berat makan resource. Makanya ditaruh sekali aja di void Start
       audioSource = GetComponent<AudioSource>(); 
    }

    // public void PlayBGM(){
    //     audioSource.Play();
    // }

    // public void PauseBGM(){
    //     audioSource.Pause();
    // }

    // public void StopBGM(){
    //     audioSource.Stop();
    // }
    public void SetVolume(){
        audioSource.volume = volumeSlider.value;
    }
    public void SetMusic(int id){
        audioSource.clip = audioClips[id];
        audioSource.Play();
        musicBtnText.text = "Music ON";
    }
    public void ToggleMusic(){
        if(audioSource.isPlaying){
            audioSource.Pause();
            musicBtnText.text = "Music OFF";
        }
        else{
            audioSource.Play();
            musicBtnText.text = "Music ON";
        }
    }
}
