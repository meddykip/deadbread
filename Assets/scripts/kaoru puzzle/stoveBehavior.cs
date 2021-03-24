using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoveBehavior : MonoBehaviour
{
// TO AVOID MULTIPLE CHECKS ... !
public GameObject checkarn_stove;
public GameObject checkoven_stove;
public GameObject checktoast_stove;

// PUZZLE MANAGER
    public GameObject msgSTOVE; // msg to show if player is right/wrong !!

    public bool wrongBUN_stove; // confirms it is WRONG

    public bool CLICKABLE_stove = false; // to enable player to CHECK

    public bool AVAILABLEstove = true;

    // Start is called before the first frame update
    void Start()
    {
        checkarn_stove.GetComponent<playerBehavior>();
        checkoven_stove.GetComponent<ovenBehavior>();
        checktoast_stove.GetComponent<toasterBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        checkaoru(); // ALLOWS checkaoru to run !!

        if (wrongBUN_stove){ // if it is true ...
            msgSTOVE.SetActive(true); // show the message !!
        }
    }
    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
            Debug.Log("stove enter"); // LMK <3
            CLICKABLE_stove = true; // ENABLE CHECK !!

        }
    }

// CHECKING BUNS...
    void checkaoru(){
        if(CLICKABLE_stove && AVAILABLEstove){ // IF clickable is TRUE , 
            if(Input.GetKeyUp(KeyCode.F)){ // and player clicks F ,
                if(!checkarn_stove.GetComponent<playerBehavior>().handsFULLoven && !checkarn_stove.GetComponent<playerBehavior>().handsFULLtoast && !checkarn_stove.GetComponent<playerBehavior>().handsFULLtoast && !checkarn_stove.GetComponent<playerBehavior>().handsFULLoven){ 
                    Debug.Log("toast activated"); // lmk <3
                    checkoven_stove.GetComponent<ovenBehavior>().AVAILABLEoven = false;
                    checktoast_stove.GetComponent<toasterBehavior>().AVAILABLEtoast = false;
                    wrongBUN_stove = true; // confirms the WRONG !!!
                    checkarn_stove.GetComponent<playerBehavior>().handsFULLstove = true;

                 // SHOW THE NEXT STEP
                    checkarn_stove.GetComponent<playerBehavior>().warningBOX.enabled = true;
                    checkarn_stove.GetComponent<playerBehavior>().warningTXT.enabled = true;
                } else if (!checkarn_stove.GetComponent<playerBehavior>().handsFULLoven && checkoven_stove.GetComponent<ovenBehavior>().CLICKABLEOVEN){
                    // IF the oven wasn't checked + BUT the player still tries to check with the oven ,
                    Debug.Log("CHECK"); // lmk !!

                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
            if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
            Debug.Log("stove exit"); // LMK <3
            CLICKABLE_stove = false; // ENABLE CHECK !!

        }
    }
}
