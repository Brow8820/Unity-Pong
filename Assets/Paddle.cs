using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private int score1;
    private int score2;
    
    float p_speed;
    float p_height;

    string input;
    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        p_height = transform.localScale.y;
        p_speed = 10f;
    }

    public void init( bool isRightPaddle){
        Vector2 pos = Vector2.zero;
        isRight = isRightPaddle;
        if(isRightPaddle){
            //place on the right of the screen, then return
            pos = new Vector2(GameManager.topR.x,0);
            pos -= transform.localScale.x * Vector2.right; //offset paddle 

            input = "PaddleRight";
        }else{
        //place on left otherwise
        pos = new Vector2(GameManager.bottomL.x,0);
        pos += transform.localScale.x * Vector2.right; //offset paddle

        input = "PaddleLeft";

        }
        transform.position = pos;

        transform.name = input;
    }

    // Update is called once per frame
    void Update()
    {
        //Move paddle
        float move = Input.GetAxis(input) * Time.deltaTime * p_speed;

        //restrict movement
        if (transform.position.y < GameManager.bottomL.y + p_height/2 && move < 0){
            move = 0;
        }
        if (transform.position.y > GameManager.topR.y - p_height/2 && move > 0){
            move = 0;
        }
        transform.Translate(move* Vector2.up);

        
    }
    public void addScore(int points){
        score1 += 1;
        UIManager.updateScore(points);
    }
}
