using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FreezerBlock : MonoBehaviour
{
    
    CollisionEvent collisionEvent=new CollisionEvent();
    public void AddcollisionListener(UnityAction listener){
        collisionEvent.AddListener(listener);
    }
    void Start(){
        EventManager.AddInvoker(this);       
    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D coll){
        string obj=coll.gameObject.name;
        if(obj=="Ball(Clone)"||obj=="Ball"){
            Camera.main.GetComponent<SoundManager>().AudioEffect(3);
            collisionEvent.Invoke();
        }
        Destroy(this.gameObject);
    }
}
