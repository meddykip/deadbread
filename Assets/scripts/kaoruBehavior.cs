﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class kaoruBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CHATS
    public bool KAORUtalk = false;
    public bool KAORUdefault = false;

// DIALOGUE UI TINGZ
    public Image kaorutxtbox; // the txtbox
    public Text kaorutxt; // the txt IN the txtbox
    public Image instructions; // the txt that shows how to progress

// MANAGES THE DIALOGUE VISUALS

    // CHAT STATES ... 
    public float KAOFAULTchat; // default: conversation manager !!!

    public float KAORRECTchat; // correct choice: conversation manager !!!

    public float KAORRONGchat; // wrong choice: conversation manager

    // SPRITES
    public GameObject KAORUsprite; // holds the sprite !
    public GameObject CARNBUNsprite;

    public GameObject talkYES; // SIGNAL that says u can talk!!!

// DIALOGUE TXT
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        kaorutxt.enabled = false;
        kaorutxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        kaorudialogue();
    }

    void OnTriggerEnter2D(Collider2D other){ // IF player enters trigger ,
        if (other.gameObject.name == "player"){
            Debug.Log("bnuuy real..."); // lmk <3
            KAORUtalk = true; // ENABLE BNUUY !!
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

// BNUUY TALK ENABLED... 
    void kaorudialogue(){
        if (KAORUtalk && Input.GetKeyDown(KeyCode.K)){ // if it is true AND K is pressed , 
            //  VISUAL UI TINGZ !!
                KAORUsprite.SetActive(true); // activate the SPRITE
                kaorutxt.enabled = true; // activate the TXT
                kaorutxtbox.enabled = true; // activate the TXTBOX
                kaorutxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                instructions.enabled = true; // activate the INSTRUCTION
            
            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                
                // CORRECT ROUTE , 
            if (carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE && !carnbeloved.GetComponent<playerBehavior>().WRONGCHOICE && !KAORUdefault){
                carnbeloved.GetComponent<playerBehavior>().WRONGCHOICE = false;
                KAORUdefault = false;
                Debug.Log("kaorrect time...");

                if(KAORRECTchat == 0){
                    Debug.Log("XIAOTO");
                    currentLine = 8;
                    kaorutxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 1){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                }  else if (KAORRECTchat == 2){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 3){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 4){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 5){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 6){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 7){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 8){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 9){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 10){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                        currentLine++;
                    }
                } else if (KAORRECTchat == 11){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRECTchat += 1;
                    }
                } else if (KAORRECTchat == 12){
                        KAORUtalk = false;
                        KAORUdefault = false;
                        // END CONVERSATION
                        Debug.Log("END CONVO");

                        // DISABLES CONVO VISUALS ,
                        KAORUsprite.SetActive(false);
                        kaorutxt.enabled = false;
                        kaorutxtbox.enabled = false;
                        instructions.enabled = false;

                        KAORRECTchat = 10;
                        currentLine = 18;

                        // player can move :)
                        carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                        carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                        carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
            // WRONG ROUTE ...
            if (!carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE && carnbeloved.GetComponent<playerBehavior>().WRONGCHOICE && !KAORUdefault){
                Debug.Log("kaorrong time...");
                KAORUdefault = false;

                if(KAORRONGchat == 0){
                    Debug.Log("XIAOTO");
                    currentLine = 20;
                    kaorutxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAORRONGchat += 1;
                        currentLine++;
                    }
                } else if (KAORRONGchat == 1){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRONGchat += 1;
                        currentLine++;
                    }
                }  else if (KAORRONGchat == 2){
                     if (Input.GetKeyDown(KeyCode.K)){
                        KAORRONGchat += 1;
                    }
                } else if (KAORRONGchat == 3){
                    KAORUtalk = false;
                    carnbeloved.GetComponent<playerBehavior>().WRONGCHOICE = false;
                    KAORUdefault = false;
                    // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    KAORUsprite.SetActive(false);
                    kaorutxt.enabled = false;
                    kaorutxtbox.enabled = false;
                    instructions.enabled = false;

                    KAORRONGchat = 0;
                    currentLine = 20;

                        // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } 
            // DEFAULT ROUTE ...
            if (!carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE && !carnbeloved.GetComponent<playerBehavior>().WRONGCHOICE){
                KAORUdefault = true;
                Debug.Log("grandpa zhongli");
            } else {
                KAORUdefault = false;
            }

            if (KAORUdefault){
                Debug.Log("woh");
                if(KAOFAULTchat == 0){
                    currentLine = 0;
                    kaorutxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 1){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 2){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 3){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 4){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 5){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 6){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                        currentLine++;
                    }
                } else if (KAOFAULTchat == 7){
                    if (Input.GetKeyDown(KeyCode.K)){
                        Debug.Log("LOLOL");
                        KAOFAULTchat += 1;
                    }
                } else if (KAOFAULTchat == 8){
                    KAORUtalk = false;
                    KAORUdefault = false;
                    // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    KAORUsprite.SetActive(false);
                    kaorutxt.enabled = false;
                    kaorutxtbox.enabled = false;
                    instructions.enabled = false;

                    KAOFAULTchat = 5;
                    currentLine = 5;

                        // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("bnuuy exit");
            KAORUtalk = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
