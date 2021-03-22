using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class warningBiscuit : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool warnTALK = false;

// DIALOGUE UI TINGZ
    public Image warntxtbox; // the txtbox
    public Text warntxt; // the txt IN the txtbox
    public Image instructions; // the txt that shows how to progress

// MANAGES THE DIALOGUE VISUALS
    public float WARNchat; // conversation manager !!!
    public GameObject WARNsprite; // holds the sprite !
    public GameObject WARNCARNsprite;

    public GameObject talkYES; // SIGNAL that says u can talk!!!
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
// TO DELETE

    public GameObject biscruok;

    // Start is called before the first frame update
    void Start()
    {
// DIALOGUE UI
        // they are hidden until triggered ...
        warntxt.enabled = false;
        warntxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        warndialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("warning time...");
            warnTALK = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void warndialogue(){
        if(warnTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("warning time...");

            // DIALOGUE MANAGEMENT
                warntxtbox.enabled = true;
                warntxt.enabled = true;
                warntxt.text = dialogueLines[currentLine];
                instructions.enabled = true; // activate the INSTRUCTION
                talkYES.SetActive(false); // deactivates the SIGNAL


            // SPRITE MANAGEMENT
                WARNCARNsprite.SetActive(true);

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if (WARNchat == 0){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 6){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 7){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 8){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 9){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 10){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 11){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 12){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 13){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 14){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 15){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 16){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 17){
                if(Input.GetKeyDown(KeyCode.K)){
                    WARNchat += 1;
                    currentLine++;
                }
            } else if (WARNchat == 18){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                warnTALK = false;
                warntxt.enabled = false;
                WARNCARNsprite.SetActive(false);
                warntxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                currentLine = 0;

                // DESTROY ... 
                Destroy(biscruok);
                Destroy(gameObject);

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("bnuuy exit");
            warnTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }


}
