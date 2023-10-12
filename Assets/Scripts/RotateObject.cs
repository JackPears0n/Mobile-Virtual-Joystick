using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Joystick jstk;

    public float sens;

    public float xRotate;
    public float yRotate;

    public float mouseX;
    public float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = jstk.Horizontal * Time.deltaTime * sens;
        mouseY = jstk.Vertical * Time.deltaTime * sens;

        yRotate += mouseX;
        xRotate -= mouseY;

        transform.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
