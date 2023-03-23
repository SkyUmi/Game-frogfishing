using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
  public  void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            audioSource.Play();
        }
    }
  

    //public static AudioClip nenSound;
    //static AudioSource nenSoundSource;

    //private void Start1()
    //{
    //    nenSound = Resources.Load<AudioClip>("fishing");

    //    nenSoundSource = GetComponent<AudioSource>();
    //}

    //public static void playsound(string clip)
    //{
    //    switch (clip)
    //    {
    //        case "fishing":
    //            nenSoundSource.PlayOneShot(nenSound);
    //            break;
    //    }
    //}
    //soundtest.playsound("fishing");

}
