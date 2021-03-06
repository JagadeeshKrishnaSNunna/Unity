using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSprite : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject ballSpanner;
    Timer timer;
    void Start()
    {
        timer=gameObject.AddComponent<Timer>();
        timer.Duration=1;
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Finished){
            Instantiate(ballSpanner);
            Destroy(gameObject);
        }
        
    }
}
