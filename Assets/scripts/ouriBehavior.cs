using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ouriBehavior : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool ouriTALK = false;

// DIALOGUE UI TINGZ
    public Image ouritxtbox; // the txtbox
    public Text ouritxt; // the txt IN the txtbox

// MANAGES THE DIALOGUE VISUALS
    public float OURIchat; // conversation manager !!!
    public GameObject OURIsprite; // holds the sprite !
    public GameObject CARNOURIsprite;
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    public GameObject kaorubeloved;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        ouritxt.enabled = false;
        ouritxtbox.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
        kaorubeloved.GetComponent<kaoruBehavior>(); // kaoru's object + script
    }

    // Update is called once per frame
    void Update()
    {
        ouridialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("catboy enter...");
            ouriTALK = true;
        }
    }

    void ouridialogue(){
        if (ouriTALK && Input.GetKeyDown(KeyCode.K)){
        
        //  VISUAL UI TINGZ !!
            OURIsprite.SetActive(true); // activate the SPRITE
            ouritxt.enabled = true; // activate the TXT
            ouritxtbox.enabled = true; // activate the TXTBOX
            ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
        
        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        if(!carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE){
            if (OURIchat == 0){ // PT.1
            currentLine = 0;
            ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 1){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 2){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 3){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 4){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 5){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 6){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 7){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 8){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 9){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 10){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 11){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 12){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 13){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 14){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 15){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 16){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 17){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 18){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 19){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 20){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 21){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 22){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 23){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 24){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 25){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 26){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 27){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 28){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 29){
               if(Input.GetKeyDown(KeyCode.K)){
                     // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    ouriTALK = false;
                    ouritxt.enabled = false;
                    OURIsprite.SetActive(false);
                    ouritxtbox.enabled = false;

                    OURIchat = 28;
                    currentLine = 29;
                    
                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
        } else if (carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE){
            Debug.Log("tomato town");
            if (OURIchat == 28 || OURIchat == 0){
                OURIchat = 30;
                currentLine = 30;
                ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                Debug.Log("hatsune");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 30){
                 Debug.Log("miku");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 31){
                 Debug.Log("oo ee oo");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 32){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 33){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 34){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 35){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 36){
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 37){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                ouriTALK = false;
                ouritxt.enabled = false;
                OURIsprite.SetActive(false);
                ouritxtbox.enabled = false;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("catboy exit");
            ouriTALK = false;
        }
    }
}
