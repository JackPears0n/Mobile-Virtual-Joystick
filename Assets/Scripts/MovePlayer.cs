using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rb;

    public Transform orientation;

    public Joystick jstk;

    public float moveSpd;

    public Vector3 moveDirect;
   
    public float xInput;
    public float yInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walk();
    }

    public void walk()
    {
        xInput = jstk.Horizontal;
        yInput = jstk.Vertical;

        moveDirect = orientation.forward * yInput + orientation.right * xInput;
        rb.AddForce(moveDirect.normalized * moveSpd * 10f, ForceMode.Force);
    }
}
