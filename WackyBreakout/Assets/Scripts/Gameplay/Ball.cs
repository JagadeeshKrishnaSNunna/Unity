using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbidy;
    Timer timer,Speedtimer;
    Vector3 speed;
    public static bool noSpeed=true;
    float ballSpeed;
    BallSpawnEvent ballSpawnEvent=new BallSpawnEvent();
    public void BallSpawnListener(UnityAction lis){
        ballSpawnEvent.AddListener(lis);
    }
    
    
    void Start()
    {
        EventManager.AddBallSwanInvoker(this);
        if(noSpeed){
            ballSpeed=ConfigurationUtils.BallImpulseForce;            
        }else{
            ballSpeed=ConfigurationUtils.BallImpulseForce*2;
        }
        SpeedUpManager.AddListener(SpeedUpHandler);
        rigidbidy=GetComponent<Rigidbody2D>();
        Vector3 direction=new Vector3(Mathf.Cos(-90*Mathf.PI/180),Mathf.Sin(-90*Mathf.PI/180));
        rigidbidy.AddForce(direction*ballSpeed);
        speed=rigidbidy.velocity;
        timer=gameObject.AddComponent<Timer>();
        timer.Duration=ConfigurationUtils.LifeTime;
        timer.Run();
        Speedtimer=gameObject.AddComponent<Timer>();
        Speedtimer.Duration=5;
        
        
    }
    public void SetDirection(Vector2 dir){
        float vX=rigidbidy.velocity.x;
        float vY=rigidbidy.velocity.y;
        float BallVelocity=Mathf.Sqrt(Mathf.Pow(vX,2)+Mathf.Pow(vY,2));
        rigidbidy.velocity=new Vector2(dir.x*BallVelocity,dir.y*BallVelocity);
    }
    public void SpeedUpHandler(){
        rigidbidy.velocity=rigidbidy.velocity*2;
        Speedtimer.Run();
        noSpeed=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Finished||transform.position.y-.05f<ScreenUtils.ScreenBottom){
            //BallSpawner bs=Camera.main.GetComponent<BallSpawner>();
            //bs.Spawn();
            ballSpawnEvent.Invoke();
            Destroy(gameObject);
        }
        if(Speedtimer.Finished){
            rigidbidy.velocity=speed;
            noSpeed=true;
        }
        
    }
}
