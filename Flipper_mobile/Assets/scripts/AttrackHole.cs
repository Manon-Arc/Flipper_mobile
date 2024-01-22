using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrackHole : MonoBehaviour
{
    private float forceMagnitude = 50f;

    public AudioClip oneShotClip;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = oneShotClip;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            audioSource.PlayOneShot(oneShotClip);
            Vector2 direction = (Vector2)transform.position - (Vector2)other.transform.position;
            other.GetComponent<Rigidbody2D>().AddForce(direction.normalized * forceMagnitude);
        }
    }
}
