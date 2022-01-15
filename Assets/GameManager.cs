using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
   // public Pause pause;

    public static Vector2 bottomL;
    public static Vector2 topR;
    
    // Start is called before the first frame update
    //recompile
    void Start()
    {
       // Instantiate(pause);

        bottomL = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topR = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Instantiate(ball);

        Paddle p1 = Instantiate(paddle) as Paddle;
        Paddle p2 = Instantiate(paddle) as Paddle;
        p1.init(true); //right paddle
        p2.init(false); //left paddle
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey("escape")){
            //will do stuff later
        //}
    }
}
