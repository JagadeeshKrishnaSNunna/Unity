using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedBlock : MonoBehaviour
{
    SpeedUpEvent speedUpEvent = new SpeedUpEvent();
    public void AddSpeedUpListener(UnityAction listener)
    {
        speedUpEvent.AddListener(listener);
    }
    void Start()
    {
        SpeedUpManager.AddInvoker(this);
    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D coll)
    {
        string obj = coll.gameObject.name;
        if (obj == "Ball(Clone)" || obj == "Ball")
        {
            Camera.main.GetComponent<SoundManager>().AudioEffect(5);
            speedUpEvent.Invoke();
        }
        Destroy(this.gameObject);
    }
}
