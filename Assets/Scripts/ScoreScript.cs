using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public static ScoreScript Instance;
    public int score = 0;
    public int nyawa = 3;
    public Text scoreText, healthText;
    public GameObject panGameOver;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(nyawa < 1){
           panGameOver.SetActive(true); 

           // print("Game Over");
        }
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "coin"){
            score+=1;
            scoreText.text = "Score: " + score;
        }

        if(other.gameObject.tag == "shot"){
            nyawa-=1;
            healthText.text = "Health: " + nyawa;
        }
    }
    public void Restart(){
        SceneManager.LoadScene("gameplay");
    }
}
