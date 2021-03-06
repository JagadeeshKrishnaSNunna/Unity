using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip []sound;
    AudioSource src;
    void Start(){
        src=gameObject.GetComponent<AudioSource>();
    }
    public void AudioEffect(int i){
        src.PlayOneShot(sound[i],1);
    }
}
