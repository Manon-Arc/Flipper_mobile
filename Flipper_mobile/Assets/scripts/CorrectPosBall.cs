using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectPosBall : MonoBehaviour
{
    private Vector3 initialPosition;
    private float timer = 0f;
    private float cooldown3sec = 3f;
    private Rigidbody2D rb;
    private float force = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if (transform.position != initialPosition)
        {
            timer = 0f;
            initialPosition = transform.position;
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= cooldown3sec)
            {
                Debug.Log("L'objet n'a pas bougé pendant 3 secondes !");
                rb.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(0.5f, 1f)).normalized * force;
                timer = 0f;
            }
        }
    }
}
