using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class chocoBehavior : MonoBehaviour
{
 // to easily ACTIVATE or DEACTIVATE CONVERSATION
    public bool chocotalk = false;

// DIALOGUE UI TINGZ
    public Image chocotxtbox; // the txtbox
    public Text chocotxt; // the txt IN the txtbox

    public Image instructions; // txt progression instructions

    // SPRITE PLACEMENTS
    public Image rightSprite;
    public Image leftSprite;

    // MANAGES THE DIALOGUE VISUALS
    public float CHOCOchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
    // Start is called before the first frame update
    void Start()
    {
// DIALOGUE UI
        // they are hidden until triggered ...
        chocotxt.enabled = false;
        chocotxtbox.enabled = false;
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
        chocodialogue();
    }

    void chocodialogue(){
        if(chocotalk && Input.GetKeyDown(KeyCode.K)){
            //  VISUAL UI TINGZ !!
                chocotxt.enabled = true; // activate the TXT
                chocotxtbox.enabled = true; // activate the TXTBOX
                chocotxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                instructions.enabled = true; // activate the INSTRUCTION
                leftSprite.enabled = true;
            
            // MOVEMENT MANAGEMENT
                // player CANNOT move ,
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
            if(CHOCOchat == 0){
                if (Input.GetKeyDown(KeyCode.K)){
                    CHOCOchat += 1;
                    currentLine = 1;
                }
            } else if (CHOCOchat == 1){
              // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    chocotalk = false;
                    chocotxt.enabled = false;
                    chocotxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;

                    // RESET
                    CHOCOchat = 0;
                    currentLine = 0;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
