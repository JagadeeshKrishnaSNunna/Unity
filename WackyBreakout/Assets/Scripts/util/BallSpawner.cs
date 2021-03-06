using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallSpawner : MonoBehaviour
{
    BallDecrementEvent ballDecrementEvent=new BallDecrementEvent();
    public void AddBallDecrementListener(UnityAction lis){
        ballDecrementEvent.AddListener(lis);
    }
    void Start(){
        EventManager.AddBallDecrementInvoker(this);
        EventManager.AddBallSpawnListener(Spawn);
    }
    // Start is called before the first frame update
    [SerializeField]GameObject ballSprite;
    
    private void Spawn(){        
        Instantiate(ballSprite);
        Camera.main.GetComponent<SoundManager>().AudioEffect(0);
        ballDecrementEvent.Invoke();
    }
    
}
