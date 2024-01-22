using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBuzzer : MonoBehaviour
{
    public AudioClip oneShotClip;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = oneShotClip;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            audioSource.PlayOneShot(oneShotClip);
        }    
    }
}
