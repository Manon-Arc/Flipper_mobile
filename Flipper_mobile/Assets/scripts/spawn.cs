using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;

    public GameObject Start_pos;

    public GameObject spawn_button;

    private int force = 70;

    public void Spawn_ball()
    {
        Debug.Log("ball cliqued");
        Start_pos = GameObject.Find("start");

        GameObject newBall = Instantiate(ball, Start_pos.transform.position, Quaternion.identity);

        Rigidbody2D rigidbodyBall = newBall.GetComponent<Rigidbody2D>();

        if (rigidbodyBall != null)
        {
            rigidbodyBall.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            spawn_button.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Rigidbody2D not found on the instantiated ball. Add a Rigidbody2D component to apply force.");
        }
    }
}
