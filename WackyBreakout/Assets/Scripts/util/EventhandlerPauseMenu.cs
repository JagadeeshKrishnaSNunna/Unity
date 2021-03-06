using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventhandlerPauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale=0;
        
    }
    public void ResumeButton(){
        Time.timeScale=1;
        Camera.main.GetComponent<SoundManager>().AudioEffect(2);
        Destroy(gameObject);
    }
     public void Quit(){
         Time.timeScale=1;
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }

    // Update is called once per frame
    
}
