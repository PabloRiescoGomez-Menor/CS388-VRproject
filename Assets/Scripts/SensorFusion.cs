using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorFusion : MonoBehaviour
{
    public UnityEngine.UI.Text[] debugLines;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        debugLines[0].text = "GYRO attitude: " + Input.gyro.attitude;
        debugLines[1].text = "GYRO gravity: " + Input.gyro.gravity;
        debugLines[2].text = "ACCELEROMETER: " + Input.acceleration;
    }
}
