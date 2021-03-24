﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class confu2ionEvent : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool confu2ionTALK = false;

// DIALOGUE UI TINGZ
    public Image confu2iontxtbox; // the txtbox
    public Text confu2iontxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image leftSprite;
    public Image rightSprite;

// MANAGES THE DIALOGUE VISUALS
    public float CONFU2IONchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        confu2iontxt.enabled = false;
        confu2iontxtbox.enabled = false;
        instructions.enabled = false;

        rightSprite.enabled = false;
        leftSprite.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        confu2iondialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("violence");
            confu2ionTALK = true;
        }
    }

    void confu2iondialogue(){
        if(confu2ionTALK){
            Debug.Log("hellokitty time...");

        // DIALOGUE MANAGEMENT
            confu2iontxtbox.enabled = true;
            confu2iontxt.enabled = true;
            instructions.enabled = true;
            confu2iontxt.text = dialogueLines[currentLine];

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if(CONFU2IONchat == 0){
                rightSprite.enabled = true;
                Debug.Log("gh");
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 6){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if (CONFU2IONchat == 7){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFU2IONchat += 1;
                    currentLine++;
                }
            } else if  (CONFU2IONchat == 8){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    confu2ionTALK = false;
                    confu2iontxt.enabled = false;
                    rightSprite.enabled = false;
                    confu2iontxtbox.enabled = false;
                    instructions.enabled = false;

                    Destroy(gameObject);

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
