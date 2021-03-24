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

// MANAGES THE DIALOGUE VISUALS
    public float RUOKchat; // conversation manager !!!
    public GameObject RUOKsprite; // holds the sprite !
    public GameObject RUOKCARNsprite;

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
        if(ruokTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("middle time...");

            // DIALOGUE MANAGEMENT
                ruoktxtbox.enabled = true;
                ruoktxt.enabled = true;
                ruoktxt.text = dialogueLines[currentLine];
                instructions.enabled = true; // activate the INSTRUCTION
                talkYES.SetActive(false); // deactivates the SIGNAL

            // SPRITE MANAGEMENT
                RUOKsprite.SetActive(true);

            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

                if(RUOKchat == 0){
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 1){
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 2){
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 3){
                    if(Input.GetKeyDown(KeyCode.K)){
                        RUOKchat += 1;
                        currentLine++;
                    }
                } else if (RUOKchat == 4){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    ruokTALK = false;
                    ruoktxt.enabled = false;
                    RUOKsprite.SetActive(false);
                    ruoktxtbox.enabled = false;
                    instructions.enabled = false;

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
