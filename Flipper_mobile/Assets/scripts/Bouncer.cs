using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouncer_L : MonoBehaviour
{
    public GameObject bouncer_L1;
    public GameObject bouncer_L2;
    public GameObject bouncer_R;

    public int force = 100;
    public int force1 = -100;

    private Rigidbody2D rdbounceL1;
    private Rigidbody2D rdbounceL2;
    private Rigidbody2D rdbounceR;

    void Start()
    {
        rdbounceL1 = bouncer_L1.GetComponent<Rigidbody2D>();
        rdbounceL2 = bouncer_L2.GetComponent<Rigidbody2D>();
        rdbounceR = bouncer_R.GetComponent<Rigidbody2D>();
    }
    

    public void Left_bouncer()
    {
        rdbounceL1.AddTorque(force);
        rdbounceL2.AddTorque(force);
    }


    public void Right_bouncer()
    {
        rdbounceR.AddTorque(force1);
    }

    public void Restart()
    {
        Debug.Log("button restart pressed");
        SceneManager.LoadScene("Game");
    }
}