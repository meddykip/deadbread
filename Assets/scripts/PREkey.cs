using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PREkey : MonoBehaviour
{

// DIALOGUE UI TINGZ
    public Image diatxtbox; // the txtbox
    public Text diatxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image leftSprite;
    public Image rightSprite;

// MANAGES THE DIALOGUE VISUALS
    public float DIAchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        diatxt.enabled = false;
        diatxtbox.enabled = false;
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
        diadialogue();
    }

    void diadialogue(){
        if(carnbeloved.GetComponent<playerBehavior>().diaTALK){
            Debug.Log("DIAlogue time...");

        // DIALOGUE MANAGEMENT
            diatxtbox.enabled = true;
            diatxt.enabled = true;
            instructions.enabled = true;
            diatxt.text = dialogueLines[currentLine];

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if(DIAchat == 0){
                rightSprite.enabled = true;
                Debug.Log("gh");
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if (DIAchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if (DIAchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if (DIAchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if (DIAchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if (DIAchat == 5){
                if(Input.GetKeyDown(KeyCode.K)){
                    DIAchat += 1;
                    currentLine++;
                }
            } else if  (DIAchat == 6){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    carnbeloved.GetComponent<playerBehavior>().diaTALK = false;
                    diatxt.enabled = false;
                    rightSprite.enabled = false;
                    diatxtbox.enabled = false;
                    instructions.enabled = false;

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
