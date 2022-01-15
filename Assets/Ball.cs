using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    float speed;

    float radius;
    Vector2 direction;

    
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized; 
        radius = transform.localScale.x / 2;
        speed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
        //bounce off top and bottom
        if (transform.position.y < GameManager.bottomL.y + radius && direction.y < 0){
            direction.y = -direction.y;
        } 
        if (transform.position.y > GameManager.topR.y -radius && direction.y > 0){
            direction.y = -direction.y;
        }

        //reset ball
        if (transform.position.x < GameManager.bottomL.x + radius && direction.x < 0){
            Paddle.addScore(1);
            //Time.timeScale = 0;
        } 
        if (transform.position.x > GameManager.topR.x -radius && direction.x > 0){
            score2 += 1;
           // UIManager.updateScore2(score2);
            //Time.timeScale = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="Paddle"){
            bool isRight = other.GetComponent<Paddle>().isRight;
            if (isRight && direction.x > 0){
                direction.x = -direction.x;
            }
            if(!isRight && direction.x < 0){
                direction.x = - direction.x;
            }
        }
    }
    


}
