using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toasterBehavior : MonoBehaviour
{
// TO AVOID MULTIPLE CHECKS ... !
public GameObject checkarn;
public GameObject checkoven;
public GameObject checkstove_toast;

// PUZZLE MANAGER
    public GameObject msgTOAST; // msg to show if player is right/wrong !!

    public bool wrongBUN; // confirms it is WRONG

    public bool CLICKABLE = false; // to enable player to CHECK

    public bool AVAILABLEtoast = true;

    // Start is called before the first frame update
    void Start()
    {
        checkarn.GetComponent<playerBehavior>();
        checkoven.GetComponent<ovenBehavior>();
        checkstove_toast.GetComponent<stoveBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        checkaoru(); // ALLOWS checkaoru to run !!

        if (wrongBUN){ // if it is true ...
            msgTOAST.SetActive(true); // show the message !!
        }
    }
    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
            Debug.Log("toast enter"); // LMK <3
            CLICKABLE = true; // ENABLE CHECK !!

        }
    }

// CHECKING BUNS...
    void checkaoru(){
        if(CLICKABLE && AVAILABLEtoast){ // IF clickable is TRUE , 
            if(Input.GetKeyUp(KeyCode.F)){ // and player clicks F ,
                if(!checkarn.GetComponent<playerBehavior>().handsFULLoven && !checkarn.GetComponent<playerBehavior>().handsFULLtoast){ 
                    Debug.Log("toast activated"); // lmk <3
                    checkoven.GetComponent<ovenBehavior>().AVAILABLEoven = false;
                    wrongBUN = true; // confirms the WRONG !!!
                    checkarn.GetComponent<playerBehavior>().handsFULLtoast = true;
        
        
                    // SHOW THE NEXT STEP!!
                    checkarn.GetComponent<playerBehavior>().warningBOX.enabled = true;
                    checkarn.GetComponent<playerBehavior>().warningTXT.enabled = true;
                } else if (!checkarn.GetComponent<playerBehavior>().handsFULLoven && checkoven.GetComponent<ovenBehavior>().CLICKABLEOVEN && checkstove_toast.GetComponent<stoveBehavior>().CLICKABLE_stove){
                    // IF the oven wasn't checked + BUT the player still tries to check with the oven ,
                    Debug.Log("CHECK"); // lmk !!


                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
            if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
            Debug.Log("toast exit"); // LMK <3
            CLICKABLE = false; // ENABLE CHECK !!

        }
    }
}
