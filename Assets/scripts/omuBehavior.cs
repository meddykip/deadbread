using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class omuBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool omuTALK = false;

// DIALOGUE UI TINGZ
    public Image omutxtbox; // the txtbox
    public Text omutxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress   

    // SPRITE HOLDERS
    public Image rightSprite;
    public Image leftSprite;

// MANAGES THE DIALOGUE VISUALS
    public float OMUchat; // conversation manager !!!
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
        omutxt.enabled = false;
        omutxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        omudialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("paperboy in..."); // lmk <3

            omuTALK = true; // talk time..
            talkYES.SetActive(true); // show SIGNAL
        }
    }

    void omudialogue(){
        if (omuTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("omu time...!!!");

            // DIALOGUE MANAGEMENT
                omutxtbox.enabled = true;
                omutxt.enabled = true;
                instructions.enabled = true; // activate the INSTRUCTION

                // SPRITES
                rightSprite.enabled = true;
                leftSprite.enabled = true;

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
            if (!carnbeloved.GetComponent<playerBehavior>().strawberrymilk){
                omutxt.text = dialogueLines[currentLine]; // activate the TXT
                if (OMUchat == 0){
                    currentLine = 0;
                   
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 1){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 2){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 3){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 4){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 5){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 6){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 7){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 8){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 9){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;
                carnbeloved.GetComponent<playerBehavior>().strawberryASK = true;

                // RESET
                OMUchat = 10;
                currentLine = 9;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (OMUchat == 10){
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 11){
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;

                // ACTIVATE nuel's dialogue
                carnbeloved.GetComponent<playerBehavior>().strawberryASK = true;

                // RESET
                OMUchat = 9;
                currentLine = 9;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } else if (carnbeloved.GetComponent<playerBehavior>().strawberrymilk){
            // strawberry milk ACQUIRED
                if (OMUchat == 9 || OMUchat == 10 || OMUchat == 11){
                        Debug.Log("berry milkis...");
                        OMUchat = 12;
                        currentLine = 9;
                        omutxt.text = dialogueLines[currentLine];
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 13){;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 14){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 15){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 16){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 17){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 18){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 19){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 20){;
                    
                     if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 21){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 22){;
                    
                      if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 23){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 24){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 25){;
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 26){;
                    
                     if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 27){;
                    
                     if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 28){;
                    Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;
                carnbeloved.GetComponent<playerBehavior>().grudgeFRIEND = true;

                Destroy(gameObject);

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
        }
    }
}

    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("paperboy out...");
            omuTALK = false;   
            talkYES.SetActive(false);
        }
    }
}
