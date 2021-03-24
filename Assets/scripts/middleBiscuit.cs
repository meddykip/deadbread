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

    public Text midqs; // biscuit's questions!

    public Image instructions; // the txt that shows how to progress

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
                    instructions.enabled = false;
                    if (Input.GetKeyDown(KeyCode.Y)){ // imy2
                        MIDBISCchat += 1;
                        currentLine++;
                    } else if (Input.GetKeyDown(KeyCode.U)){ // about you
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
                midqs.enabled = false;
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
                midqs.enabled = false;
                instructions.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 14){
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
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 17){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 18){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 19){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                } else if (MIDBISCchat == 20){ // I CHOICE PT. 1
                    midqs.enabled = false;
                    instructions.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 21){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 22){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 23){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 24){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 25){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 26){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                } else if (MIDBISCchat == 27){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 28){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 29){
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
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 32){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 33){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 34){
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
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                }  else if (MIDBISCchat == 39){ // O: HP
                    midqs.enabled = false;
                    instructions.enabled = true;
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 40){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 41){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 42){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 43){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 44){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 45){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 46){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 47){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 48){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 49){
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat = 9;
                        currentLine = 9;
                    }
                }  else if (MIDBISCchat == 50){ // END CONVO PT.1 : "i'll continue finding those keys..!"
                    midqs.enabled = false;
                    instructions.enabled = true;
                    Debug.Log("leaving now!!");
                    if (Input.GetKeyDown(KeyCode.K)){
                        MIDBISCchat += 1;
                        currentLine++;
                    }
                }  else if (MIDBISCchat == 51){ // END CONVO PT.2 : "we'll see you later!"
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
