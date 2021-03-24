using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class milkBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    public bool milktalk = false;

// DIALOGUE UI TINGZ
    public Image milktxtbox; // the txtbox
    public Text milktxt; // the txt IN the txtbox

    public Image instructions; // txt progression instructions

    // SPRITE PLACEMENTS
    public Image rightSprite;
    public Image leftSprite;

    // MANAGES THE DIALOGUE VISUALS
    public float MILKchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
    // Start is called before the first frame update
    void Start()
    {
// DIALOGUE UI
        // they are hidden until triggered ...
        milktxt.enabled = false;
        milktxtbox.enabled = false;
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
        milkdialogue();
    }

    void milkdialogue(){
        if(milktalk && Input.GetKeyDown(KeyCode.K)){
            //  VISUAL UI TINGZ !!
                milktxt.enabled = true; // activate the TXT
                milktxtbox.enabled = true; // activate the TXTBOX
                milktxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                instructions.enabled = true; // activate the INSTRUCTION
                leftSprite.enabled = true;
            
            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
            if(MILKchat == 0){
                if (Input.GetKeyDown(KeyCode.K)){
                    MILKchat += 1;
                    currentLine = 1;
                }
            } else if (MILKchat == 1){
              // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    milktalk = false;
                    milktxt.enabled = false;
                    milktxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;

                    // RESET
                    MILKchat = 0;
                    currentLine = 0;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
