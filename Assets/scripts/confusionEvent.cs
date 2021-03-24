using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class confusionEvent : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool confus1onTALK = false;

// DIALOGUE UI TINGZ
    public Image confus1ontxtbox; // the txtbox
    public Text confus1ontxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image leftSprite;
    public Image rightSprite;

// MANAGES THE DIALOGUE VISUALS
    public float CONFUS1ONchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        confus1ontxt.enabled = false;
        confus1ontxtbox.enabled = false;
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
        confus1ondialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("violence");
            confus1onTALK = true;
        }
    }

    void confus1ondialogue(){
        if(confus1onTALK){
            Debug.Log("hellokitty time...");

        // DIALOGUE MANAGEMENT
            confus1ontxtbox.enabled = true;
            confus1ontxt.enabled = true;
            instructions.enabled = true;
            confus1ontxt.text = dialogueLines[currentLine];

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if(CONFUS1ONchat == 0){
                rightSprite.enabled = true;
                Debug.Log("gh");
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFUS1ONchat += 1;
                    currentLine++;
                }
            } else if (CONFUS1ONchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFUS1ONchat += 1;
                    currentLine++;
                }
            } else if (CONFUS1ONchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFUS1ONchat += 1;
                    currentLine++;
                }
            } else if (CONFUS1ONchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFUS1ONchat += 1;
                    currentLine++;
                }
            } else if (CONFUS1ONchat == 4){
                if(Input.GetKeyDown(KeyCode.K)){
                    CONFUS1ONchat += 1;
                    currentLine++;
                }
            } else if  (CONFUS1ONchat == 5){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    confus1onTALK = false;
                    confus1ontxt.enabled = false;
                    rightSprite.enabled = false;
                    confus1ontxtbox.enabled = false;
                    instructions.enabled = false;

                    Destroy(gameObject);

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
