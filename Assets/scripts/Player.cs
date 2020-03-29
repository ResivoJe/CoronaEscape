using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement; //broj za koliko se pomera levo ili desno lik 
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public Text healthDisplay;   
    public GameObject playAgain;
    public GameObject infectedPlayer1;
    public Sprite infectedPlayer;
    bool status = true;
    private float ScreenWidth;

    public GameObject character;
    private Rigidbody2D characterbody;

    void Start() {
        targetPos = new Vector2(0, -3);   
        //playAgain = GameObject.Find("PlayAgain");
        ScreenWidth = Screen.width;
        characterbody = character.GetComponent<Rigidbody2D>();
        playAgain.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();

        if(health <= 0){
            playAgain.SetActive(true);
            Time.timeScale = 0f;
            infectedPlayer1.GetComponent<SpriteRenderer>().sprite = infectedPlayer;
            if(status == true){
         
                transform.Rotate (0, 0, 75);  
                status = false;
            }
           
        }

        int j = 0;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        while(j < Input.touchCount){
            if(Input.GetTouch(j).position.x > ScreenWidth / 2 && transform.position.x < maxHeight ){
                targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y); 
                transform.position = targetPos;
            }
            if(Input.GetTouch(j).position.x < ScreenWidth / 2 && transform.position.x > minHeight){
                targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y); 
                transform.position = targetPos;
            }
            j++;
        }
      
    }
}
