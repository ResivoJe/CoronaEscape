using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement; //broj za koliko se pomera levo ili desno lik 
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    void Start() {

        targetPos = new Vector2(0, -3);   

    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            SceneManager.LoadScene(0);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxHeight){

            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y); 
            transform.position = targetPos;

        }else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minHeight){

            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y); 
            transform.position = targetPos;

        }
    }
}
