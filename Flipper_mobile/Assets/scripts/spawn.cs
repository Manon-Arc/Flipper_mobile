using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    public float force = 20f;

    void Start()
    {
        GameObject newBall = Instantiate(ball, transform.position, Quaternion.identity);

        Rigidbody2D rigidbodyBall = newBall.GetComponent<Rigidbody2D>();

        if (rigidbodyBall != null)
        {
            rigidbodyBall.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogWarning("Rigidbody2D not found on the instantiated ball. Add a Rigidbody2D component to apply force.");
        }
    }
}
