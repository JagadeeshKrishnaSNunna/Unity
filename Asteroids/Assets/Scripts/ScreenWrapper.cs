using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject gObj=collision.gameObject;
        if (gObj.name!="bullets(Clone)"&&gObj.name!="Ship")
        {
            Vector2 pos = transform.position;
            if (pos.x > 0)
            {
                if (pos.x > (ScreenUtils.ScreenRight - 5))
                {
                    pos.x = ScreenUtils.ScreenLeft + 1.5f;
                }
            }
            else
            {
                if (pos.x < (ScreenUtils.ScreenLeft + 5))
                {
                    pos.x = ScreenUtils.ScreenRight - 1.5F;
                }
            }
            if (pos.y > 0)
            {
                if (pos.y > (ScreenUtils.ScreenTop - 5))
                {
                    pos.y = ScreenUtils.ScreenBottom + 1.5f;
                }
            }
            else
            {
                if (pos.y < (ScreenUtils.ScreenBottom + 5))
                {
                    pos.y = ScreenUtils.ScreenTop - 1.5f;
                }
            }
            transform.position = pos;
        }

    }

    // Update is called once per frame

}
