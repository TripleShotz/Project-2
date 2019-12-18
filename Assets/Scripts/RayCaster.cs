using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.name);
        }
        
        Debug.DrawRay(Camera.main.transform.position, ray.direction * 4, Color.green);
    }
}
