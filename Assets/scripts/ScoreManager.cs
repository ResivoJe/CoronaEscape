using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int i = 0;
    public Text scoreDisplay;

    private void Update() {
        scoreDisplay.text = score.ToString();    
    }
    private void OnTriggerEnter2D(Collider2D other) {
        i++;
        if(other.CompareTag("Obstacle")){
            if(i == 4){
                score++;
                i = 0;
                Debug.Log(score);
            }
        }   
    }
}
