using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject bullet;
    Rigidbody2D rb2D;
    float Zinput;
    Vector2 direction;
    const float thrust=3.0f;
    // Update is called once per frame
    public void Start(){
        rb2D=GetComponent<Rigidbody2D>(); 
    }
    float angle = 90.0f;

    bool flag=false;
    public void SpriteRotation(){
        Zinput=Input.GetAxis("Horizontal");
        if(Zinput!=0){
            if(!flag){
                flag=true;
                if(Zinput<0){
                    angle =-90;
                }else{
                    angle =90;
                }
                transform.Rotate(0f,0f,angle*Time.deltaTime*20,Space.World);
            }
            
            
        }else{
            flag=false;
        }
    }
    
    void FixedUpdate()
    {
        SpriteRotation();

        transform.Translate(2f*Time.deltaTime,0f,0f); 
        float inp=Input.GetAxis("Thrust");
        const int speed=3;
        if(inp>0){
            transform.Translate(1f*inp*Time.deltaTime*speed,0f,0f);
        } 
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            Rigidbody2D fire=Instantiate(bullet.GetComponent<Rigidbody2D>(),transform.position,transform.rotation);
            fire.transform.Translate(1,0,0);
             AudioManager.Play(AudioClipName.PlayerShot);
        }      
    }
}
