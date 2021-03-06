using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject Astro1;
    [SerializeField]
    GameObject Astro2;
    [SerializeField]
    GameObject Astro3;  
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] Astros={Astro1,Astro2,Astro3};
        Instantiate(Astros[(int)Random.Range(0,3)],new Vector2(ScreenUtils.ScreenLeft+1.5f,.0f),Quaternion.identity);
        Instantiate(Astros[(int)Random.Range(0,3)],new Vector2(ScreenUtils.ScreenRight-1.5f,.0f),Quaternion.identity);
        Instantiate(Astros[(int)Random.Range(0,3)],new Vector2(0f,ScreenUtils.ScreenTop-1.5f),Quaternion.identity);
        Instantiate(Astros[(int)Random.Range(0,3)],new Vector2(0f,ScreenUtils.ScreenBottom+1.5f),Quaternion.identity);        
    }

    // Update is called once per frame
}
