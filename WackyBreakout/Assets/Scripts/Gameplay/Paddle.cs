using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Timer timer;
    float BounceAngleHalfRange = 60 * Mathf.PI / 180;
    float halfColliderWidth;
    float halfColliderHeigh;
    bool freezEffect=false;
    
    // Start is called before the first frame update
    void Start()
    {
        EventManager.AddListener(setFreezEffect);
        rigidbody = GetComponent<Rigidbody2D>();
        halfColliderWidth = GetComponent<BoxCollider2D>().size.x / 2;
        halfColliderHeigh = GetComponent<BoxCollider2D>().size.y / 2;
        timer=gameObject.AddComponent<Timer>();
        timer.Duration=ConfigurationUtils.FreezTime;
        
    }
    void setFreezEffect()
    {
        timer.Run();
        freezEffect = true;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Camera.main.GetComponent<SoundManager>().AudioEffect(1);
        if (coll.gameObject.CompareTag("Ball") && TopCollisionDetact(coll))
        {
            // calculate new ball direction
            float ballOffsetFromPaddleCenter = transform.position.x -
                coll.transform.position.x;
            float normalizedBallOffset = ballOffsetFromPaddleCenter /
                halfColliderWidth;
            float angleOffset = normalizedBallOffset * BounceAngleHalfRange;
            float angle = Mathf.PI / 2 + angleOffset;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            // tell ball to set direction to new direction
            Ball ballScript = coll.gameObject.GetComponent<Ball>();
            ballScript.SetDirection(direction);
        }
    }
    float CalculateClampedX(float x)
    {
        if (x + halfColliderWidth > ScreenUtils.ScreenRight || x - halfColliderWidth < ScreenUtils.ScreenLeft) { return transform.position.x; }
        else
            return x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer.Finished){
            freezEffect=false;
        }
        if (!freezEffect)
        {
            float inp = Input.GetAxis("Horizontal");
            float xPos = CalculateClampedX(transform.position.x + ConfigurationUtils.PaddleMoveUnitsPerSecond * Time.deltaTime * inp);
            rigidbody.MovePosition(new Vector2(xPos, transform.position.y));
        }
        

    }
    bool TopCollisionDetact(Collision2D coll)
    {
        float collisionY = coll.GetContact(0).point.y;
        float topY = transform.position.y + halfColliderHeigh;
        if (collisionY <= topY + 0.05 && collisionY >= topY - 0.05)
            return true;
        else return false;
    }
}
