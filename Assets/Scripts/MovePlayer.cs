using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform orientation;

    public Joystick jstk;

    public Rigidbody rb;

    public float moveSpd;
   
    public float xInput;
    public float yInput;

    Vector3 moveDirect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = jstk.Horizontal;
        yInput = jstk.Vertical;
        walk();
    }

    public void walk()
    {
        moveDirect = orientation.forward * yInput + orientation.right * xInput;
        rb.AddForce(moveDirect.normalized * moveSpd * 10f, ForceMode.Force);
    }
}
