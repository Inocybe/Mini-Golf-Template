using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{

    public GameObject StartingPoint;
    public Transform ball_transform;
    public Rigidbody ball_rb;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            ball_rb.velocity = new Vector3(0, 0, 0);
            ball_transform.position = StartingPoint.transform.position;
        }
    }
}
