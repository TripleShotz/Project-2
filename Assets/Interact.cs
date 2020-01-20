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
        interactText.text = "Press q to hack";
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Interactable")){
            if(Input.GetKeyDown(KeyCode.Q)){
                if(other.gameObject.transform.name == "laptop H"){
                    interactText.text = "Letter: H";
                }else if(other.gameObject.transform.name == "laptop A"){
                    interactText.text = "Letter: A";
                }
                else if(other.gameObject.transform.name == "laptop C"){
                    interactText.text = "Letter: C";
                }
                else if(other.gameObject.transform.name == "laptop K"){
                    interactText.text = "Letter: K";
                }
                else if(other.gameObject.transform.name == "laptop E"){
                    interactText.text = "Letter: E";
                }
                else if(other.gameObject.transform.name == "laptop R"){
                    interactText.text = "Letter: R";
                }
            }
        }
    }

    void OnTriggerExit(Collider other){
        interactText.text = "";
    }

}
