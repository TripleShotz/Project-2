using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    Vector3 focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        focalPoint = transform.parent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");

        //transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        //transform.RotateAround(focalPoint, horizontalInput);
        transform.RotateAround(focalPoint, Vector3.up, rotationSpeed * horizontalInput);
        transform.LookAt(focalPoint + new Vector3(0f,2f,0f));
    }

    
}
