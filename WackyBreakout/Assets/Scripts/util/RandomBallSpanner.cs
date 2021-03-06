using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomBallSpanner : MonoBehaviour
{
    // Start is called before the first frame update
    Timer timer;
    BallSpawnEvent ballSpawnEvent=new BallSpawnEvent();
    public void BallSpawnListener(UnityAction lis){
        ballSpawnEvent.AddListener(lis);
    }
    void Start()
    {
        EventManager.AddBallSwanInvoker(this);
        ballSpawnEvent.Invoke();
        timer=gameObject.AddComponent<Timer>();
        float d=Random.Range(ConfigurationUtils.Min,ConfigurationUtils.Max);
        timer.Duration=d;
        timer.Run(); 
    }
    void TimerReset(){
        float d=Random.Range(ConfigurationUtils.Min,ConfigurationUtils.Max);
        timer.Duration=d;
        timer.Run();

    }


    // Update is called once per frame
    void Update()
    {
        if(timer.Finished){
            //BallSpawner bs=Camera.main.GetComponent<BallSpawner>();
            //bs.Spawn();
            ballSpawnEvent.Invoke();
            print("ola");
            timer=null;
            TimerReset();
        }        
    }
}
