using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update

    SoundManager soundManager;
    void Start(){
        soundManager=Camera.main.GetComponent<SoundManager>();
        
        if(ConfigurationUtils.PlayController){
            GetComponent<AudioSource>().Play();
        }
    }
    public void playButton(){
        ConfigurationUtils.PlayController=true;
        SceneManager.LoadScene("Scene0");
    }
    public void QuitButton(){
        ConfigurationUtils.PlayController=true;
        soundManager.AudioEffect(2);
        Application.Quit();
    }
    public void helpButton(){
        ConfigurationUtils.PlayController=true;
        SceneManager.LoadScene("Help");
    }

}
