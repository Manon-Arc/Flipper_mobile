using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bouncer;
    public int force = 100;

    private Rigidbody2D rigidbodyBall;

    void Start()
    {
        rigidbodyBall = bouncer.GetComponent<Rigidbody2D>();

        if (rigidbodyBall != null)
        {
            rigidbodyBall.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rigidbodyBall.AddTorque(force);
        }
    }
}
