using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    Timer timer;
    // Start is called before the first frame update
    void Start(){
        timer=gameObject.AddComponent<Timer>();
        timer.Duration=2;
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(1f*Time.deltaTime*8,0f,0f);  
        if(timer.Finished){
            Destroy(this.gameObject);
        }  
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject gObj=col.gameObject;
        if(gObj.name=="Asteroid1(Clone)"||gObj.name=="Asteroid3(Clone)"||gObj.name=="Asteroid2(Clone)"){
            Vector3 size=gObj.transform.localScale;
            
            if(size.x>.5){
                size.x=size.x-.2f;
                size.y=size.y-.2f;
                gObj.transform.localScale=size;
                Instantiate(gObj,gObj.transform.position,gObj.transform.rotation).name=gObj.name;
            }else{
                Destroy(gObj);
            }

        }
        
    }
    
}
