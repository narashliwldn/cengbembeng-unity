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

    [Header("Player Prefs")]
    //untuk menyimpan variabel maka disimpan dengan string
    string PREF_BGMVOL = "bgmVol";
    string PREF_BGMSTATUS = "bgmStatus";


    // Start is called before the first frame update
    void Start()
    {
       Instance = this;
       //ambil komponen audiosource. Tapi cukup berat makan resource. Makanya ditaruh sekali aja di void Start
       audioSource = GetComponent<AudioSource>(); 
       //volumeSlider.value = PlayerPrefs.GetFloat("bgmVol", 0.5f); & audioSource.volume = PlayerPrefs.GetFloat("bgmVol", 0.5f);
       volumeSlider.value = audioSource.volume = PlayerPrefs.GetFloat("bgmVol", 0.5f);

       if(PlayerPrefs.GetInt(PREF_BGMSTATUS, 1) == 1){
           audioSource.Play();
           musicBtnText.text = "Music ON";
       }
       else{
           audioSource.Pause();
           musicBtnText.text = "Music OFF";
       }
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
        PlayerPrefs.SetFloat("bgmVol", audioSource.volume);
    }
    public void SetMusic(int id){
        audioSource.clip = audioClips[id];
        audioSource.Play();
        musicBtnText.text = "Music ON";
        PlayerPrefs.SetInt(PREF_BGMSTATUS, 1);
    }
    public void ToggleMusic(){
        if(audioSource.isPlaying){
            audioSource.Pause();
            musicBtnText.text = "Music OFF";
            PlayerPrefs.SetInt(PREF_BGMSTATUS, 0);
        }
        else{
            audioSource.Play();
            musicBtnText.text = "Music ON";
            PlayerPrefs.SetInt(PREF_BGMSTATUS, 1);
        }
    }
}
