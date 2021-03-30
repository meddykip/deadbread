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

    public Image instructions; // the txt that shows how to progress

    // SPRITES

    public Image rightSprite;
    public Image leftSprite;

    public Image rname;
    public Image lname;

        // SPRITES
        public Sprite ouritag;
        public Sprite carntag;

        public Sprite o1;
        public Sprite o2;
        public Sprite o3;
        public Sprite o4;

        public Sprite c1;
        public Sprite c2;
        public Sprite c3;

// MANAGES THE DIALOGUE VISUALS
    public float OURIchat; // conversation manager !!!
    public GameObject talkYES; // SIGNAL that says u can talk!!!
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
        instructions.enabled = false;

        rightSprite.enabled = false;
        rname.enabled = false;
        leftSprite.enabled = false;
        lname.enabled = false;

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
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void ouridialogue(){
        if (ouriTALK && Input.GetKeyDown(KeyCode.K)){
        
        //  VISUAL UI TINGZ !!
            ouritxt.enabled = true; // activate the TXT
            ouritxtbox.enabled = true; // activate the TXTBOX
            instructions.enabled = true; // activate the INSTRUCTION
            talkYES.SetActive(false); // deactivates the SIGNAL
        
        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        if(!carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE){
            ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
            if (OURIchat == 0){ // PT.1
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ouritag;
                rightSprite.sprite = o2;
                currentLine = 0;
                if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 1){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.enabled = true;
                leftSprite.sprite = c2;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 2){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = o1; 
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 3){ 
                rightSprite.sprite = o3;
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
                rightSprite.sprite = o1;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 7){
                rightSprite.sprite = o4;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 8){
                rightSprite.sprite = o1;
                Debug.Log("mmroww");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 9){
                     // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    ouriTALK = false;
                    ouritxt.enabled = false;
                    ouritxtbox.enabled = false;
                    instructions.enabled = false;
                    leftSprite.enabled = false;
                    rightSprite.enabled = false;
                    rname.enabled = false;


                    OURIchat = 10;
                    currentLine = 9;
                    
                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (OURIchat == 10){
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ouritag;
                rightSprite.sprite = o4;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                }
            } else if (OURIchat == 11){
                     // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    ouriTALK = false;
                    ouritxt.enabled = false;
                    ouritxtbox.enabled = false;
                    instructions.enabled = false;
                    rightSprite.enabled = false;
                    leftSprite.enabled = false;
                    rname.enabled = false;


                    OURIchat = 10;
                    currentLine = 9;
                    
                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        } else if (carnbeloved.GetComponent<playerBehavior>().RIGHTCHOICE){
            Debug.Log("tomato town");
            if (OURIchat == 10 || OURIchat == 11 || OURIchat == 0){
                OURIchat = 12;
                currentLine = 9;
                ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                Debug.Log("hatsune");
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ouritag;
                rightSprite.sprite = o4;
               
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 13){
                rightSprite.sprite = o1;
                 Debug.Log("miku");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 14){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.enabled = true;
                leftSprite.sprite = c2;
                 Debug.Log("oo ee oo");
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 15){
                
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 16){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = o2;
                
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 17){
                rightSprite.sprite = o3;
                
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 18){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c3;
                
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 19){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = o2;
                
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 20){
                rightSprite.sprite = o1;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 21){
                rightSprite.sprite = o4;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 22){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                ouriTALK = false;
                ouritxt.enabled = false;
                ouritxtbox.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;

                // RESET
                OURIchat = 23;
                currentLine = 20;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                } else if (OURIchat == 23){
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ouritag;
                rightSprite.sprite = o4;
               currentLine = 20;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 24){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                ouriTALK = false;
                ouritxt.enabled = false;
                ouritxtbox.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                // RESET
                OURIchat = 25;
                currentLine = 21;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (OURIchat == 25){
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ouritag;
                rightSprite.sprite = o1;
                currentLine = 21;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 26){
                rightSprite.sprite = o4;
               if(Input.GetKeyDown(KeyCode.K)){
                    OURIchat += 1;
                    currentLine++;
                    ouritxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
                }
            } else if (OURIchat == 27){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                ouriTALK = false;
                ouritxt.enabled = false;
                ouritxtbox.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                // RESET
                OURIchat = 23;
                currentLine = 20;

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
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
