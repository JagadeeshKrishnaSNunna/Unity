using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField]GameObject paddle;
    [SerializeField]GameObject []stdBlock;
    static float height,width,posx=0,posy=0;
    static int inde;

    // Start is called before the first frame update
    void Start()
    {
        inde=(int)(Random.Range(0,4));
        Instantiate(paddle);
        GameObject p=Instantiate(stdBlock[inde]);
        posx=ScreenUtils.ScreenLeft+1.8f;
        posy=(ScreenUtils.ScreenTop-.5f);
        Destroy(p);
        for(int i=0;i<3;i++){
            float Startpos=(ScreenUtils.ScreenTop-ScreenUtils.ScreenBottom)/5;            
            for(int j=0;j<7;j++){
                Instantiate(stdBlock[inde],new Vector3(posx,posy,0),Quaternion.identity);
                posx+=2+.5f;
                inde=(int)(Random.Range(0,4));
            }
            posy-=1/1.5f;
            posx=ScreenUtils.ScreenLeft+1.8f;
        }

        
    }

    // Update is called once per frame
    
}
