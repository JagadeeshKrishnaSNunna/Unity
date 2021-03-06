using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    bool walk=true;

    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(-44,2,35); 
        transform.rotation=Quaternion.Euler(0,180,0); 
             
    }

    // Update is called once per frame
    void Update()
    {
        
        if(walk){
            transform.position=transform.position+Camera.main.transform.forward*Time.deltaTime*3;
            transform.position=new Vector3(transform.position.x,1,transform.position.z);
        }
    }
}
