using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    private bool isOpened = false;
    
    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            if (Input.GetKeyDown("e"))
            {
                isOpened = true;
                door.transform.rotation = new Quaternion(0,0,0,0);
            } 
        }
    }
}
