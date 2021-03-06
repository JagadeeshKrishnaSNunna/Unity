using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI textScore;
    [SerializeField]TextMeshProUGUI textBallCount;
    [SerializeField]TextMeshProUGUI gameOver;
    Text text;
    static float score;
    static float ballLeft;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.AddPointsListener(Increment);
        EventManager.BallDecrementListener(BallDecrement);
        textScore.text="Score: "+score;
        ballLeft=ConfigurationUtils.BallLeft;
        textBallCount.text="Ball Left: "+ballLeft;
        gameOver.text="";
        
    }
    public static void Increment(float points){
        score+=points;
    }
    public static void BallDecrement(){
        ballLeft--;

    }

    // Update is called once per frame
    void Update()
    {
        if(ballLeft<1){
            Time.timeScale=0;
            gameOver.text="You Score...!\n"+score;
        }
        textScore.text="score: "+score;
        textBallCount.text="Ball Left: "+ballLeft;        
    }
}
