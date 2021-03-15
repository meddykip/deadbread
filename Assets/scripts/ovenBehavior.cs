using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenBehavior : MonoBehaviour
{
// TO AVOID MULTIPLE CHECKS ... !

    public GameObject checkarn_oven;
    public GameObject checktoaster;

// PUZZLE MANAGER
    public GameObject msgOVEN; // msg to show if player is right/wrong !!

    public bool rightBUN; // confirms it is WRONG

    public bool CLICKABLEOVEN = false; // to enable player to CHECK

    public bool AVAILABLEoven = true;

// REWARDS for completing the puzzle
    public GameObject key;

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        checkarn_oven.GetComponent<playerBehavior>();
        checktoaster.GetComponent<toasterBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        checkaoru(); // ALLOWS checkaoru to run !!

        if (rightBUN){ // if it is true ...
            msgOVEN.SetActive(true); // show the message !!
        }
    }
    void OnTriggerEnter2D(Collider2D other){
    // KAORU PUZZLE CODE ...

        if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
            Debug.Log("bnuuy enter"); // LMK <3
            CLICKABLEOVEN = true; // ENABLE CHECK !!
        }
    }

// CHECKING BUNS...
    void checkaoru(){
        if(CLICKABLEOVEN && AVAILABLEoven){ // IF clickable is TRUE , 
            if(Input.GetKey(KeyCode.F)){ // and player clicks F ,
                if (!checkarn_oven.GetComponent<playerBehavior>().handsFULLoven && !checkarn_oven.GetComponent<playerBehavior>().handsFULLtoast){
                    checktoaster.GetComponent<toasterBehavior>().AVAILABLEtoast = false;
                    Debug.Log("oven activated"); // lmk <3
                    rightBUN = true; // confirms the RIGHT !!!
                    checkarn_oven.GetComponent<playerBehavior>().handsFULLoven = true;
                } else if (checkarn_oven.GetComponent<playerBehavior>().handsFULLoven && checktoaster.GetComponent<toasterBehavior>().CLICKABLE){
                   // IF the oven was checked + BUT the player still tries to check with the toast , 
                    Debug.Log("illegal oven"); // lmk !!

                    // SHOW THE WARNING , just in case the player triggers this lol
                    checkarn_oven.GetComponent<playerBehavior>().warningBOX.enabled = true;
                    checkarn_oven.GetComponent<playerBehavior>().warningTXT.enabled = true;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
            if (other.gameObject.tag == "Player"){ // IF the toaster collides with the player , 
                Debug.Log("bnuuy exit"); // LMK <3
                CLICKABLEOVEN = false; // ENABLE CHECK !!

        }
    }
}
