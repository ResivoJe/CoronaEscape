using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int i = 0;
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
