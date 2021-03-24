using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class finalBiscuit : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool finalTALK = false;

// DIALOGUE UI TINGZ
    public Image finaltxtbox; // the txtbox
    public Text finaltxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

// MANAGES THE DIALOGUE VISUALS
    public float FINALchat; // conversation manager !!!

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
        finaltxt.enabled = false;
        finaltxtbox.enabled = false;
        instructions.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        finaldialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("final fantasy...");
        finalTALK = true;
        talkYES.SetActive(true); // shows the SIGNAL !

    }

    void finaldialogue(){
        if(finalTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("warning time...");

        // DIALOGUE MANAGEMENT
            finaltxtbox.enabled = true;
            finaltxt.enabled = true;
            finaltxt.text = dialogueLines[currentLine];
            instructions.enabled = true; // activate the INSTRUCTION
            talkYES.SetActive(false); // deactivates the SIGNAL
            


        // SPRITE MANAGEMENT


        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if (FINALchat == 0){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 1){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 2){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 3){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 4){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 5){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 6){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 7){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 8){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 9){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 10){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 11){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 12){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 13){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 14){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 15){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 16){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 17){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 18){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 19){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 20){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 21){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 22){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 23){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 24){
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            }  else if (FINALchat == 25){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                finalTALK = false;
                finaltxt.enabled = false;
  
                finaltxtbox.enabled = false;
                instructions.enabled = false;

                // RESET
                FINALchat = 24;
                currentLine = 24;

                // DESTROY ...
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
            finalTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
