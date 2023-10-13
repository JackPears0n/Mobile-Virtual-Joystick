using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScreen : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    Quaternion GyroToUnity(Quaternion gyroInput)
    {
        var eulerRotation = gyroInput.eulerAngles;
        return Quaternion.Euler(0, 0, eulerRotation.z - 90);
    }
}
