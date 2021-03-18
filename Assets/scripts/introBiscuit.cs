using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class introBiscuit : MonoBehaviour
{

// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool introTALK = false;

// DIALOGUE UI TINGZ
    public Image introtxtbox; // the txtbox
    public Text introtxt; // the txt IN the txtbox

// MANAGES THE DIALOGUE VISUALS
    public float BISCTROchat; // conversation manager !!!
    public GameObject BISCTROsprite; // holds the sprite !
    public GameObject CARNTROsprite;
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        introtxt.enabled = false;
        introtxtbox.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        introdialogue();
    }

    private void OnTriggerEnter2D(Collider2D other){ // IF player enters trigger , 
        if (other.gameObject.name == "player"){
            Debug.Log("INTRODUCTIONS.... "); // lmk <3
            introTALK = true; // ENABLE ..
        }
    }
    void introdialogue(){
        if (introTALK){
            Debug.Log("intro time...");

        // DIALOGUE MANAGEMENT
            introtxtbox.enabled = true;
            introtxt.enabled = true;
            introtxt.text = dialogueLines[currentLine];

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if(BISCTROchat == 0){
                BISCTROsprite.SetActive(true);
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    Debug.Log("onward to 2");
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 6){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 7){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 8){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 9){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 10){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 11){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 12){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 13){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 14){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 15){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 16){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 17){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 18){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 19){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 20){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 21){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 22){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 23){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 24){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 25){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 26){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 27){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                introTALK = false;
                introtxt.enabled = false;
                BISCTROsprite.SetActive(false);
                introtxtbox.enabled = false;

                // RESET
                currentLine = 0;

                // DESTROY ... 
                Destroy(gameObject);

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }

        }
    }
}
