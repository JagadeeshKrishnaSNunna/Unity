using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Block : MonoBehaviour
{
    AddPointsEvent addPointsEvent=new AddPointsEvent();
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D coll){
        string obj=coll.gameObject.name;
        if(obj=="Ball(Clone)"||obj=="Ball"){
            Camera.main.GetComponent<SoundManager>().AudioEffect(1);
            addPointsEvent.Invoke(ConfigurationUtils.Score);
        }
        Destroy(this.gameObject);
    }
    void Start(){
        EventManager.AddPointsInvoker(this);
    }
    public void AddAddPointsListener(UnityAction<float> list){
        addPointsEvent.AddListener(list);
    }
}
