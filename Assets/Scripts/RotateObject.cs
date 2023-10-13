using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Joystick jstk;

    public float sens;

    public float xRotate;
    public float yRotate;

    public float inputX;
    public float inputY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = jstk.Horizontal * Time.deltaTime * sens;
        inputY = jstk.Vertical * Time.deltaTime * sens;

        yRotate += inputX;
        xRotate -= inputY;

        transform.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
