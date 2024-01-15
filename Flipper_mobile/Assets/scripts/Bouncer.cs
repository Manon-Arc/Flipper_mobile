using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (rdbounceL1 != null)
        {
            rdbounceL1.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }

        if(rdbounceL2 != null)
        {
            rdbounceL2.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }

        if(rdbounceR != null)
        {
            rdbounceR.AddForce(Vector2.up * force1, ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            rdbounceL1.AddTorque(force);
            rdbounceL2.AddTorque(force);
        }
        
        if (Input.GetKey("z"))
        {
            rdbounceR.AddTorque(force1);
        }
    }
}