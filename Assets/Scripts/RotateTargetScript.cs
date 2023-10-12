using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTargetScript : MonoBehaviour
{
    public Transform orientation;

    public Joystick jstk;

    public float xRotate;
    public float yRotate;

    public float xJoy;
    public float yJoy;

    public float sens;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateObj();

    }

    public void RotateObj()
    {
        xJoy = jstk.Horizontal * Time.deltaTime * sens;
        yJoy = jstk.Vertical * Time.deltaTime * sens;

        yRotate += xJoy;
        xRotate -= yJoy;

        //transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        transform.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
