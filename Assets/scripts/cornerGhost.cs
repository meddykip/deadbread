using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class cornerGhost : MonoBehaviour
{
    // to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool cornerTALK = false;

// DIALOGUE UI TINGZ
    public Image cornertxtbox; // the txtbox
    public Text cornertxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    // SPRITES

    public Image rightSprite;
    public Image leftSprite;

// MANAGES THE DIALOGUE VISUALS
    public float CORNERchat; // conversation manager !!!
    public GameObject talkYES; // SIGNAL that says u can talk!!!
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        cornertxt.enabled = false;
        cornertxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        cornerdialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("cornering...");
            cornerTALK = true;
        }
    }

    void cornerdialogue(){
        if (cornerTALK && Input.GetKeyDown(KeyCode.K)){
        //  VISUAL UI TINGZ !!
            cornertxt.enabled = true; // activate the TXT
            cornertxtbox.enabled = true; // activate the TXTBOX
            instructions.enabled = true; // activate the INSTRUCTION
            talkYES.SetActive(false); // deactivates the SIGNAL
        
        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if (CORNERchat == 0){
                if (Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine = 0;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE

                }
            } else if (CORNERchat == 6){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 7){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 8){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 9){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 10){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 11){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                cornerTALK = false;
                cornertxt.enabled = false;
                cornertxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                CORNERchat = 12;
                currentLine = 10;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (CORNERchat == 12){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 13){
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            }  else if (CORNERchat == 14){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                cornerTALK = false;
                cornertxt.enabled = false;
                cornertxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                CORNERchat = 12;
                currentLine = 10;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } 
        
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("cornerout..");
            cornerTALK = false;
        }
    }
}
