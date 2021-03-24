using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class introCarn : MonoBehaviour
{
    // to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool carnINTRO = false;

// DIALOGUE UI TINGZ
    public Image introtxtbox; // the txtbox
    public Text introtxt; // the txt IN the txtbox

    public Image introstructions; // txt progression instructions

    // SPRITE PLACEMENTS
    public Image rightSprite;
    public Image leftSprite;

    // MANAGES THE DIALOGUE VISUALS
    public float CARNTROchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #
    public GameObject talkYES; // SIGNAL that says u can talk!!!

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    
    // Start is called before the first frame update
    void Start()
    {
// DIALOGUE UI
        // they are hidden until triggered ...
        introtxt.enabled = false;
        introtxtbox.enabled = false;
        introstructions.enabled = false;

        rightSprite.enabled = false;
        leftSprite.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        carntrodialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "player"){
            carnINTRO = true;
            talkYES.SetActive(true);
        }
    }

    void carntrodialogue(){
        if (carnINTRO && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("intro time...");

        // DIALOGUE MANAGEMENT
            introtxtbox.enabled = true;
            introtxt.enabled = true;
            introstructions.enabled = true;
            introtxt.text = dialogueLines[currentLine];
            leftSprite.enabled = true;

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if (CARNTROchat == 0){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            } else if (CARNTROchat == 1){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 2){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 3){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 4){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 5){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 6){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 7){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 8){
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            } else if (CARNTROchat == 9){
                // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    carnINTRO = false;
                    introtxt.enabled = false;
                    introtxtbox.enabled = false;
                    introstructions.enabled = false;
                    leftSprite.enabled = false;

                    // RESET
                    currentLine = 0;

                    // DESTROY ... ACTIVATE
                    Destroy(gameObject);


                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
