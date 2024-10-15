using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Vector3 eulerToRotateHorizontal = Vector3.zero;
    Vector3 eulerToRotateVertical = Vector3.zero;
    [SerializeField] int rotationSpeed = 1;
    [SerializeField] GameObject cameraToRotate;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") < 0) //Left
        {
            eulerToRotateHorizontal.y = -1;
        }

        if (Input.GetAxis("Mouse X") > 0) //Right
        {
            eulerToRotateHorizontal.y = 1;
        }

        if (Input.GetAxis("Mouse X") == 0)
        {
            eulerToRotateHorizontal.y = 0;
        }

        if (Input.GetAxis("Mouse Y") < 0 && eulerToRotateVertical.x < 90) //Down
        {
            eulerToRotateVertical.x = 1;
        }

        if (Input.GetAxis("Mouse Y") > 0 && eulerToRotateVertical.x > -90) //Up
        {
            eulerToRotateVertical.x = -1;
        }

        if (Input.GetAxis("Mouse Y") == 0)
        {
            eulerToRotateVertical.x = 0;
        }

        transform.Rotate(eulerToRotateHorizontal * rotationSpeed * Time.deltaTime, Space.Self);
        cameraToRotate.transform.Rotate(eulerToRotateVertical * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
