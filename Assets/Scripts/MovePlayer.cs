using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform orientation;

    public Joystick jstk;

    public float moveSpd;
   
    public float xInput;
    public float yInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = jstk.Horizontal;
        yInput = jstk.Vertical;
    }

    public void walk()
    {

    }
}
