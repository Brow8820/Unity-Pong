using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    //[SerializeField]
   // private Text scoreText2;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "" + 0;
   //  scoreText2.text = "" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(int playerScore){
        _scoreText.text = playerScore.ToString();
    }

    //public void updateScore2(int playerScore){
    // scoreText2.text = playerScore.ToString(); 
   // }
}
