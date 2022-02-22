using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Platform dependent compilation (to compile only on computer)

public class CamController : MonoBehaviour
{
    // Bool to know if mouse contorl is active
    public bool mouseControl;

    // Mouse invert on the y axis
    public bool invertY;

    // Previous mouse position
    public Vector3 oldMousePos;

    // Rotation
    private Vector3 tempRotation;

    // Mouse sensitivity
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Lock cursor to put it back to the middle
        //Cursor.lockState = CursorLockMode.Locked;

        //Cursor.visible = true;
        /*if (mouseControl)
        {
            
            // Unlock cursor to allow movement
            Cursor.lockState = CursorLockMode.None;

            // Get the new mouse postion before reset
            Vector3 newMousePos = Input.mousePosition;
            oldMousePos = newMousePos;

            // Rotate the camera corresponding to the new mouse position
            if (invertY)
                tempRotation = transform.rotation.eulerAngles + new Vector3(-newMousePos.y, newMousePos.x, 0.0f) * sensitivity;
            else
                tempRotation = transform.rotation.eulerAngles + new Vector3(newMousePos.y, newMousePos.x, 0.0f) * sensitivity;

            // Set rotation
            transform.rotation = Quaternion.Euler(tempRotation);
        }*/
    }
}
