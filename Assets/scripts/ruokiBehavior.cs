using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ruokiBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool ruokTALK = false;

// DIALOGUE UI TINGZ
    public Image ruoktxtbox; // the txtbox
    public Text ruoktxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    // SPRITES
    public Image showcase;
    public Image leftSprite; // holds the sprite !
    public Image rightSprite;

    public Image lname;
    public Image rname;

        // SPRITES  

        public Sprite qs;

        public Sprite ruokitag;
        public Sprite carntag;

        public Sprite r1;
        public Sprite r2;
        public Sprite r3;
        public Sprite r4;
        public Sprite c1;
        public Sprite c2;
        public Sprite c3;
        public Sprite c4;


// MANAGES THE DIALOGUE VISUALS
    public float RUOKchat; // conversation manager !!!

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
        ruoktxt.enabled = false;
        ruoktxtbox.enabled = false;
        instructions.enabled = false;
        showcase.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        ruokidialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("clown enter..");
            ruokTALK = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void ruokidialogue(){
        if(ruokTALK){
            Debug.Log("middle time...");

            // DIALOGUE MANAGEMENT
                ruoktxtbox.enabled = true;
                ruoktxt.enabled = true;
                ruoktxt.text = dialogueLines[currentLine];
                talkYES.SetActive(false); // deactivates the SIGNAL

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

                if(RUOKchat == 0){ // CONVO HUB ...!
                    instructions.enabled = false; // activate the INSTRUCTION
                    showcase.enabled = true;
                    showcase.sprite = qs;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = true;
                    rname.sprite = ruokitag;
                    rightSprite.enabled = true;
                    rightSprite.sprite = r3;
                    if(Input.GetKey(KeyCode.Y)){
                        Debug.Log("reciprocated..!");
                        RUOKchat += 1;
                        currentLine++;
                    } else if (Input.GetKey(KeyCode.U)){
                        Debug.Log("do or DONUT...");
                        RUOKchat = 4;
                        currentLine = 4;
                    } else if (Input.GetKey(KeyCode.I)){
                        Debug.Log("ikanyaide");
                        RUOKchat = 15;
                        currentLine = 15;
                    }
                } else if (RUOKchat == 1){
                    rname.enabled = false;
                    showcase.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.sprite = c1;
                    instructions.enabled = true; // activate the INSTRUCTION
                    if(Input.GetKey(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 2){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 3){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat = 0;
                        currentLine = 0;
                    }
                } else if (RUOKchat == 4){
                    instructions.enabled = true; // activate the INSTRUCTION
                    showcase.enabled = false;
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 5){
                    leftSprite.sprite = c2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 6){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 7){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 8){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 9){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 10){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 11){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 12){
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 13){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c1;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 14){
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.sprite = c4;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat = 0;
                        currentLine = 0;
                    }
                }  else if (RUOKchat == 15){
                        instructions.enabled = true; // activate the INSTRUCTION
                        showcase.enabled = false;
                    rname.enabled = false;
                    lname.enabled = true;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c2;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                }  else if (RUOKchat == 16){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = r3;
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 17){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    ruokTALK = false;
                    ruoktxt.enabled = false;
                    ruoktxtbox.enabled = false;
                    instructions.enabled = false;
                    rightSprite.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = false;

                    // RESET
                    RUOKchat = 0;
                    currentLine = 0;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("clown exit");
            ruokTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
