using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class omuBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool omuTALK = false;
    public bool cookierun;

// DIALOGUE UI TINGZ
    public Image omutxtbox; // the txtbox
    public Text omutxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress   

    // SPRITE HOLDERS
    public Image rightSprite;
    public Image leftSprite;

    public Image showcase;

    public Image rname;
    public Image lname;

        // SPRITES

        public Sprite cookey;
        public Sprite carntag;
        public Sprite omutag;

        public Sprite c1; 
        public Sprite c2;
        public Sprite c3;
        public Sprite c4; 
        public Sprite c5; 
        public Sprite o1;
        public Sprite o2;
        public Sprite o3;
        public Sprite o4;

// MANAGES THE DIALOGUE VISUALS
    public float OMUchat; // conversation manager !!!
    public GameObject talkYES; // SIGNAL that says u can talk!!!
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT
    public GameObject carnbeloved;
    public GameObject grudgebeloved;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        omutxt.enabled = false;
        omutxtbox.enabled = false;
        instructions.enabled = false;
        showcase.enabled = false;

        rname.enabled = false;
        lname.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script

        grudgebeloved.GetComponent<strawberryBehavior>();
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

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
            if (!carnbeloved.GetComponent<playerBehavior>().strawberrymilk){
                omutxt.text = dialogueLines[currentLine]; // activate the TXT
                if (OMUchat == 0){
                    currentLine = 0;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c2;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 1){
                    leftSprite.sprite = c1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 2){
                    lname.enabled = false;
                    rname.enabled = true;
                    rname.sprite = omutag;
                    rightSprite.enabled = true;
                    rightSprite.sprite = o1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 3){
                    lname.enabled = true;
                    rname.enabled = false;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 4){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = o2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 5){
                    lname.enabled = true;
                    rname.enabled = false;
                    leftSprite.sprite = c3;

                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 6){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = o1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 7){
                    rightSprite.sprite = o3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 8){
                    rightSprite.sprite = o2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 9){
                    lname.enabled = true;
                    rname.enabled = false;
                    leftSprite.sprite = c3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 10){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;
                carnbeloved.GetComponent<playerBehavior>().strawberryASK = true;

                // RESET
                OMUchat = 11;
                currentLine = 10;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (OMUchat == 11){
                    rightSprite.enabled = true;
                    rname.enabled = true;
                    rname.sprite = omutag;
                    rightSprite.sprite = o1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                    }
                } else if (OMUchat == 12){
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                rname.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;

                // ACTIVATE nuel's dialogue
                carnbeloved.GetComponent<playerBehavior>().strawberryASK = true;

                // RESET
                OMUchat = 11;
                currentLine = 10;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } else if (carnbeloved.GetComponent<playerBehavior>().strawberrymilk){
            // strawberry milk ACQUIRED
                if (OMUchat == 9 || OMUchat == 10 || OMUchat == 11|| OMUchat == 12){
                        grudgebeloved.GetComponent<strawberryBehavior>().milkGET = false;
                        Debug.Log("berry milkis...");
                        OMUchat = 13;
                        currentLine = 10;
                        omutxt.text = dialogueLines[currentLine];

                        rightSprite.enabled = true;
                        rightSprite.sprite = o4;
                        rname.enabled = true;
                        rname.sprite = omutag;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 14){
                    rightSprite.sprite = o2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 15){;
                    rname.enabled = false;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c4;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 16){;
                    leftSprite.sprite = c3;
                    showcase.enabled = true;
                    showcase.sprite = cookey;
                    cookierun = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 17){;
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = o1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 18){;
                    showcase.enabled = false;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 19){;
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 20){;
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = o1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 21){;
                    rname.enabled = false;
                    lname.enabled = true;
                     if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 22){;
                    lname.enabled = false;
                    rname.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 23){;
                    rightSprite.sprite = o2;
                      if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 24){;
                    leftSprite.sprite = c5;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 25){;
                    
                    lname.enabled = true;
                    rname.enabled = false;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 26){;
                    
                    lname.enabled = false;
                    rname.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 27){;
                    rightSprite.enabled = false;
                    lname.enabled = true;
                    rname.enabled = false;
                    leftSprite.sprite = c2;
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
                lname.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;
                carnbeloved.GetComponent<playerBehavior>().grudgeFRIEND = true;

                OMUchat = 29;
                currentLine = 26;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (OMUchat == 29){;
                    rightSprite.enabled =  true;
                    rightSprite.sprite = o2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        OMUchat += 1;
                        currentLine++;
                        omutxt.text = dialogueLines[currentLine];
                    }
                } else if (OMUchat == 30){
                        Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                omuTALK = false;
                omutxt.enabled = false;
                rightSprite.enabled = false;
                omutxtbox.enabled = false;
                instructions.enabled = false;
                carnbeloved.GetComponent<playerBehavior>().grudgeFRIEND = true;

                OMUchat = 29;
                currentLine = 26;

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
