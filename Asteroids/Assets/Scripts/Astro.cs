using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro : MonoBehaviour
{
    static bool state=true;
    public static bool shipState{
        get{return state;}
    }
    // Start is called before the first frame update

    Vector2 di,pos;


    void Start(){
        pos=transform.position;
        if(pos.x<0){
            di=new Vector2(1*Time.deltaTime,0);
        }
        if(pos.x>0){
            di=new Vector2(-1*Time.deltaTime,0);
        }
        if(pos.y<0){
            di=new Vector2(0,1*Time.deltaTime);
        }
        if(pos.y>0){
            di=new Vector2(0,-1*Time.deltaTime);
        }
        

    }

    Rigidbody2D ola;
    // Update is called once per frame
    void Update()
    {
        
        ola=GetComponent<Rigidbody2D>();
        transform.Translate(di);
        if(transform.localScale.x<0.5){
            Destroy(this.gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject gObj=col.gameObject;
        if(gObj.name=="Ship"){
            AudioManager.Play(AudioClipName.PlayerDeath);
            state=false;
            Destroy(col.gameObject);
        }
        if(gObj.name=="bullets(Clone)"){
            AudioManager.Play(AudioClipName.AsteroidHit);
            Destroy(gObj);
        }
    }
}
