using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    public AudioClip error;
    public AudioClip life;
    public AudioSource soundSource;
    void Start()
    {
        soundSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void _Life()
    {
       soundSource.PlayOneShot(life);
    }

    public void _Error()
    {
        soundSource.PlayOneShot(error);
    }
}

