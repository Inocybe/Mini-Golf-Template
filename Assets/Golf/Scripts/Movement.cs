using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public int up_force;
    public int down_force;

    private int up = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Moving();
    }

    public void Moving()
    {
        if (up == 1)
        {
            rb.AddForce(0, up_force, 0);
        }
        else
        {
            rb.AddForce(0, down_force, 0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        rb.velocity = new Vector3(0, 0, 0);
        up *= -1;
    }
}
