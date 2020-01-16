using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Text interactText;

    // Start is called before the first frame update
    void Start()
    {
        interactText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Interactable"))
        interactText.text = "press q to use";
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Interactable")){
            if(Input.GetKeyDown(KeyCode.Q)){
                if(other.gameObject.transform.name == "laptop H"){
                    interactText.text = "press q to use";
                }else if(other.gameObject.transform.name == "laptop A"){
                    interactText.text = "press q to use";
                }
            }
        }
    }

    void OnTriggerExit(Collider other){
        interactText.text = "";
    }

}
