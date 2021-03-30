using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class preBiscuit : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool preTALK = false;

// DIALOGUE UI TINGZ
    public Image pretxtbox; // the txtbox
    public Text pretxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    // SPRITES
    public Image leftSprite; // holds the sprite !
    public Image rightSprite;

    public Image lname;
    public Image rname;

        // SPRITES  

        public Sprite bisctag;
        public Sprite carntag;

        public Sprite b1;
        public Sprite b2;
        public Sprite b3;

        public Sprite c1;
        public Sprite c2;

// MANAGES THE DIALOGUE VISUALS
    public float PREchat; // conversation manager !!!

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
        pretxt.enabled = false;
        pretxtbox.enabled = false;
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
        predialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("biscin..");
            preTALK = true;
            talkYES.SetActive(true);
        }
    }

    void predialogue(){
        if (preTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("middle time...");

            // DIALOGUE MANAGEMENT
                pretxtbox.enabled = true;
                pretxt.enabled = true;
                pretxt.text = dialogueLines[currentLine];
                instructions.enabled = true; // activate the INSTRUCTION
                talkYES.SetActive(false); // deactivates the SIGNAL

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

                if (PREchat == 0){
                    rname.enabled = true;
                    rname.sprite = bisctag;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 1){
                    rname.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.sprite = c1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 2){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 3){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c1; 
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 4){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 5){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 6){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 7){
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 8){
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 9){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 10){
                    // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    preTALK = false;
                    pretxt.enabled = false;
                    pretxtbox.enabled = false;
                    instructions.enabled = false;
                    rightSprite.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = false;

                    // RESET
                    PREchat = 11;
                    currentLine = 10;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (PREchat == 11){
                    rname.enabled = true;
                    rname.sprite = bisctag;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        PREchat += 1;
                        currentLine += 1;
                    }
                } else if (PREchat == 12){
                    // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    preTALK = false;
                    pretxt.enabled = false;
                    pretxtbox.enabled = false;
                    instructions.enabled = false;
                    rightSprite.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = false;
                    
                    // RESET
                    PREchat = 11;
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
            Debug.Log("biscout");
            preTALK = false;
            talkYES.SetActive(false);
        }
    }
}
