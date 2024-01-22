using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrackHole : MonoBehaviour
{
    public float forceMagnitude = 50f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            Debug.Log("force add");
            Vector2 direction = (Vector2)transform.position - (Vector2)other.transform.position;
            other.GetComponent<Rigidbody2D>().AddForce(direction.normalized * forceMagnitude);
        }
    }
}
