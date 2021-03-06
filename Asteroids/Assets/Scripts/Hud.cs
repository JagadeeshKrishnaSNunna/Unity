using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    [SerializeField]
    Text Scoretext;
    [SerializeField]
    Text endtext;
    int score = 0;
    string yo = "Score : ";
    // Start is called before the first frame update
    void Start()
    {
        Scoretext.text = yo + score.ToString();
    }
    float elaspedTime = 0;
    // Update is called once per frame
    void Update()
    {
        if (Astro.shipState)
        {
            if (elaspedTime >= 1)
            {
                elaspedTime = 0;
                score += 1;
                Scoretext.text = yo + score.ToString();
            }
            else
            {
                elaspedTime += Time.deltaTime;
            }
        }else{
            endtext.text="Game Over......!";
        }

    }
}
