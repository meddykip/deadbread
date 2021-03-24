using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class strawberryBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    public bool strawberrytalk = false;

// DIALOGUE UI TINGZ
    public Image strawberrytxtbox; // the txtbox
    public Text strawberrytxt; // the txt IN the txtbox

    public Image instructions; // txt progression instructions

    // SPRITE HOLDERS
    public Image rightSprite;
    public Image leftSprite;

    // MANAGES THE DIALOGUE VISUALS
    public float STRAWBERRYchat; // conversation manager !!!
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT
    public GameObject carnbeloved;
    
// REWARDS
    public GameObject key;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
// DIALOGUE UI
        // they are hidden until triggered ...
        strawberrytxt.enabled = false;
        strawberrytxtbox.enabled = false;
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
        strawberrydialogue();
    }

    void strawberrydialogue(){
        if(strawberrytalk && Input.GetKeyDown(KeyCode.K)){
            //  VISUAL UI TINGZ !!
                strawberrytxt.enabled = true; // activate the TXT
                strawberrytxtbox.enabled = true; // activate the TXTBOX
                 strawberrytxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                instructions.enabled = true; // activate the INSTRUCTION
                leftSprite.enabled = true;
            
            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
        // IF the grudge isnt our friend ...
            if(!carnbeloved.GetComponent<playerBehavior>().grudgeFRIEND){
                if(STRAWBERRYchat == 0){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 1){
                    carnbeloved.GetComponent<playerBehavior>().ichimilk.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 2){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 3){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 4){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 5){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 6){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 7){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if(STRAWBERRYchat == 8){
                    if (Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                    }
                } else if (STRAWBERRYchat == 9){
                // END CONVERSATION
                        Debug.Log("END CONVO");

                        // DISABLES CONVO VISUALS ,
                        strawberrytalk = false;
                        strawberrytxt.enabled = false;
                        strawberrytxtbox.enabled = false;
                        instructions.enabled = false;
                        leftSprite.enabled = false;

                        // RESET
                        STRAWBERRYchat = 8;
                        currentLine = 8;
                        

                        // player can move :)
                        carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                        carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                        carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } 
        // IF the grudge is our friend ... CONFIRMED :)
            else if(carnbeloved.GetComponent<playerBehavior>().grudgeFRIEND){
                Debug.Log ("MOEIFIED GRUDGE TRUE");
                if (STRAWBERRYchat == 8 || STRAWBERRYchat == 9){
                    STRAWBERRYchat = 10;
                    currentLine = 8;
                    strawberrytxt.text = dialogueLines[currentLine];
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 11){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 12){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 13){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 14){
                    
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 15){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 16){
                    key.SetActive(true); // RECEIVE 404KEY ...!
                    button.SetActive(true); // button is open...
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 17){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 18){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 19){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 20){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 21){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 22){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 23){
                    Debug.Log("END CONVO");
                    strawberrytalk = false;
                    strawberrytxt.enabled = false;
                    strawberrytxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;

                    STRAWBERRYchat = 24;
                    currentLine = 21;

                // MOVEMENT RELATED
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (STRAWBERRYchat == 24){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 25){
                    Debug.Log("END CONVO");
                    strawberrytalk = false;
                    strawberrytxt.enabled = false;
                    strawberrytxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;

                    STRAWBERRYchat = 26;
                    currentLine = 22;

                // MOVEMENT RELATED
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (STRAWBERRYchat == 26){
                    if(Input.GetKeyDown(KeyCode.K)){
                        STRAWBERRYchat += 1;
                        currentLine++;
                        strawberrytxt.text = dialogueLines[currentLine];  
                    }
                } else if (STRAWBERRYchat == 27){
                    Debug.Log("END CONVO");
                    strawberrytalk = false;
                    strawberrytxt.enabled = false;
                    strawberrytxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;

                    STRAWBERRYchat = 24;
                    currentLine = 21;

                // MOVEMENT RELATED
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } 
        } 
    }
}
