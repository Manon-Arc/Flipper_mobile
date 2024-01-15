using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject ball;
    void Start()
    {
        GameObject newball = Instantiate(ball, transform.position, Quaternion.identity);
    }
}
