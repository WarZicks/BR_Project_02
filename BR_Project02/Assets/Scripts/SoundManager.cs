using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager Singleton;

    private AudioSource AudioSource;

    public AudioClip Snd_Shotgun;
    public AudioClip Snd_Impact;


    // Use this for initialization
    void Start ()
    {
        AudioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Shotgun_Feedback()
    {
        AudioSource.clip = Snd_Shotgun;
        AudioSource.Play();
    }

    public void Impact_Feedback()
    {
        AudioSource.clip = Snd_Impact;
        AudioSource.Play();
    }
}
