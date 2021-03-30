using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class middleBiscuit : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool midTALK = false;

// DIALOGUE UI TINGZ
    public Image midtxtbox; // the txtbox
    public Text midtxt; // the txt IN the txtbox

    public Image midqs; // biscuit's questions!

    public Image instructions; // the txt that shows how to progress

    // SPRITES
    public Image leftSprite; // holds the sprite !
    public Image rightSprite;
    public Image showcase;

    public Image lname;
    public Image rname;

        // SPRITES  
        public Sprite qs;
        public Sprite bbuff;

        public Sprite ruokitag;
        public Sprite carntag;
        public Sprite bisctag;

        public Sprite b1;
        public Sprite b2;
        public Sprite b3;
        public Sprite r1;
        public Sprite r2;
        public Sprite r3;
        public Sprite r4;
        public Sprite c1;
        public Sprite c2;

// MANAGES THE DIALOGUE VISUALS
    public float MIDBISCchat; // conversation manager !!!

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
        midtxt.enabled = false;
        midtxtbox.enabled = false;
        instructions.enabled = false;
        midqs.enabled = false;

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
        midialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("middle bsicuit");
            midTALK = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void midialogue(){
        if (midTALK){
            Debug.Log("middle time...");

            // DIALOGUE MANAGEMENT
                midtxtbox.enabled = true;
                midtxt.enabled = true;
                midtxt.text = dialogueLines[currentLine];
                instructions.enabled = true; // activate the INSTRUCTION
                talkYES.SetActive(false); // deactivates the SIGNAL

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    
                if(MIDBISCchat == 0){
                    MIDBISCchat = 9;
                    currentLine = 9;
                } else if (MIDBISCchat == 1){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 2){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 3){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 4){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 4){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 5){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 6){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 7){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 8){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 9){  // CONVERSATION HUB
                    Debug.Log("BISCUIT Q + A");
                    midqs.enabled = true;
                    midqs.sprite = qs;
                    instructions.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = true;
                    rname.sprite = bisctag;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.U)){ // about you
                        MIDBISCchat = 13;
                        currentLine = 13;
                    } else if (Input.GetKeyDown(KeyCode.I)){ // parents
                        MIDBISCchat = 20;
                        currentLine = 20;
                    } else if (Input.GetKeyDown(KeyCode.O)){ //HP
                        MIDBISCchat = 39;
                        currentLine = 39;
                    } else if (Input.GetKeyDown(KeyCode.P)){ // END
                        MIDBISCchat = 50;
                        currentLine = 50;
                    }
                } else if (MIDBISCchat == 10){ // Y CHOICE PT.1 : i miss you too
                //.enabled = false;
                instructions.enabled = true;
                Debug.Log("i miss you too..!!");
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 11){ // Y CHOICE PT.2
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 12){ // Y CHOICE PT.3
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                } else if (MIDBISCchat == 13){ //U CHOICE PT.1
                    rightSprite.sprite = b1;
                    midqs.enabled = false;
                    instructions.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 14){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 15){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 16){
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 17){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 18){
                    rightSprite.sprite = r1;
                    rname.sprite = ruokitag;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 19){
                    rname.enabled = false;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                } else if (MIDBISCchat == 20){ // I CHOICE PT. 1
                    midqs.enabled = false;
                    instructions.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 21){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 22){
                    rightSprite.sprite = r3;
                    rname.sprite = ruokitag;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 23){
                    rname.sprite = bisctag;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 24){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 25){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 26){
                    rightSprite.sprite = r2;
                    rname.sprite = ruokitag;

                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 27){
                    rname.sprite = bisctag;
                    rightSprite.sprite = b2;

                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 28){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 29){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 30){
                    
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 31){
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 32){
                    rname.enabled = false;
                    lname.enabled = true;
                    lname.sprite =  carntag;
                    leftSprite.enabled = true;
                    leftSprite.sprite = c2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 33){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 34){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 35){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 36){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 37){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 38){
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                }  else if (MIDBISCchat == 39){ // O: HP
                    midqs.enabled = false;
                    instructions.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 40){
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 41){
                    showcase.enabled = true;
                    showcase.sprite = bbuff;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 42){
                    
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 43){
                    rname.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.sprite = c1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 44){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 45){
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 46){
                    showcase.enabled = false;
                    rname.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    leftSprite.sprite = c2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 47){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b2;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 48){
                    rname.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    leftSprite.sprite = c1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 49){
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b1;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                }  else if (MIDBISCchat == 50){ // END CONVO PT.1 : "i'll continue finding those keys..!"
                    rname.enabled = false;
                    leftSprite.enabled = true;
                    lname.enabled = true;
                    lname.sprite = carntag;
                    leftSprite.sprite = c2;
                    midqs.enabled = false;
                    instructions.enabled = true;
                    Debug.Log("leaving now!!");
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 51){ // END CONVO PT.2 : "we'll see you later!"
                    lname.enabled = false;
                    rname.enabled = true;
                    rightSprite.enabled = true;
                    rightSprite.sprite = b3;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 52;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 52){
                    // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    midTALK = false;
                    midtxt.enabled = false;
                    midtxtbox.enabled = false;
                    instructions.enabled = false;
                    rightSprite.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    rname.enabled = false;

                    // RESET
                    MIDBISCchat = 9;
                    currentLine = 9;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }  else if (MIDBISCchat == 53){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 54){ 
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("clown exit");
            midTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
