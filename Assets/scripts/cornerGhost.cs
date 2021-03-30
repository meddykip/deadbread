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

    public Image rname;
    public Image lname;

        //SPRITES
        
        public Sprite carntag;
        public Sprite ghostag;

        public Sprite c1;
        public Sprite c2;
        public Sprite c3;
        public Sprite g1;
        public Sprite g2;

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

        rightSprite.enabled = false;
        rname.enabled = false;
        leftSprite.enabled = false;
        lname.enabled = false;

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
            talkYES.SetActive(true); // shows the SIGNAL !
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
                rightSprite.enabled = true;
                rname.enabled = true;
                rightSprite.sprite = g1;
                rname.sprite = ghostag;
                if (Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine = 0;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 1){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.enabled = true;
                leftSprite.sprite = c2;
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
                rname.enabled = true;
                lname.enabled = false;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 4){
                rname.enabled = false;
                lname.enabled = true;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 5){
                rname.enabled = true;
                lname.enabled = false;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE

                }
            } else if (CORNERchat == 6){
                rightSprite.sprite = g2;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 7){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c3;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 8){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = g1;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 9){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c2;
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
                leftSprite.enabled = false;
                rightSprite.enabled = false;
                lname.enabled = false;

                // RESET
                CORNERchat = 12;
                currentLine = 10;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (CORNERchat == 12){
                rname.enabled = true;
                rightSprite.enabled = true;
                rname.sprite = ghostag;
                rightSprite.sprite = g2;
                if(Input.GetKeyDown(KeyCode.K)){
                    CORNERchat += 1;
                    currentLine++;
                    cornertxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (CORNERchat == 13){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.enabled = true;
                leftSprite.sprite = c3;
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
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;

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
            talkYES.SetActive(false); // shows the SIGNAL !
        }
    }
}
