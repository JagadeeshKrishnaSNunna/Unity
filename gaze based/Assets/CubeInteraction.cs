using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CubeInteraction : MonoBehaviour
{
    private float timer;
    const float totalTime=2f;
    bool isGazed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGazed){
            timer +=Time.deltaTime;
            if(timer>totalTime){
                timer=0;
                PointerDown();
                GetComponent<Collider>().enabled=false;
                GetComponent<AudioSource>().Play();

            }
        }
        
    }
    public void PointerEnter(){
        isGazed=true;
        Debug.Log("Enter");
    }
    public void PointerExit(){
        Debug.Log("exit");
        isGazed=false;
    }
    public void PointerDown(){
        Debug.Log("Done");
    }
}
