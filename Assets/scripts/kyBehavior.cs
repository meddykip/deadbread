using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class kyBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool kyTALK = false;

// DIALOGUE UI TINGZ
    public Image kytxtbox; // the txtbox
    public Text kytxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

// MANAGES THE DIALOGUE VISUALS
    public float KYchat; // conversation manager !!!
    public GameObject KYsprite; // holds the sprite !
    public GameObject KYCARNsprite;

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
        kytxt.enabled = false;
        kytxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        kydialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("pocky enter...");
            kyTALK = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void kydialogue(){
        if (kyTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("ky time...!!!");

        // DIALOGUE MANAGEMENT
            KYsprite.SetActive(true);
            kytxtbox.enabled = true;
            kytxt.enabled = true;
            kytxt.text = dialogueLines[currentLine];
            instructions.enabled = true; // activate the INSTRUCTION

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if (KYchat == 0){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 6){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 7){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 8){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 9){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 10){
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 11){
                Debug.Log("11");
                if(Input.GetKeyDown(KeyCode.K)){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                kyTALK = false;
                kytxt.enabled = false;
                KYsprite.SetActive(false);
                kytxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                KYchat = 12;
                currentLine = 12;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } else if (KYchat == 12){
                Debug.Log("12");
                if(Input.GetKeyDown(KeyCode.K)){
                    Debug.Log("xiao");
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 13){
                Debug.Log("13");
                if(Input.GetKeyDown(KeyCode.K)){
                    KYchat += 1;
                    currentLine++;
                }
            } else if (KYchat == 14){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                kyTALK = false;
                kytxt.enabled = false;
                KYsprite.SetActive(false);
                kytxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                KYchat = 12;
                currentLine = 12;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("pocky exit...");
            kyTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
