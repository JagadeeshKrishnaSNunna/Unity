using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBlock : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D coll){
        string obj=coll.gameObject.name;
        if(obj=="Ball(Clone)"||obj=="Ball"){
            Camera.main.GetComponent<SoundManager>().AudioEffect(1);
            Hud.Increment(ConfigurationUtils.Bonus);
        }
        Destroy(this.gameObject);
    }
}
