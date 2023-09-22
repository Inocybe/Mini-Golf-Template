using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{

    public Vector3 StartingPoint;
    public Rigidbody ball;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            ball.velocity = new Vector3(0, 0, 0);
            ball.position = StartingPoint;
        }
    }
}
