using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class introBiscuit : MonoBehaviour
{

// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool introTALK = false;

// DIALOGUE UI TINGZ
    public Image introtxtbox; // the txtbox
    public Text introtxt; // the txt IN the txtbox

    public Image introstructions; // txt progression instructions

    // SPRITE PLACEMENTS
    public Image rightSprite;

    public Image leftSprite;

    public Image rname;
    public Image lname;

    public Image showcase;

    //NAMETAGS

    public Sprite ruoktag;
    public Sprite bisctag;

    // SPRITES

    public Sprite showkeys;
    public Sprite b1;
    public Sprite b2;
    public Sprite b3;

    public Sprite r1;

// MANAGES THE DIALOGUE VISUALS
    public float BISCTROchat; // conversation manager !!!

    public GameObject talkYES; // SIGNAL that says u can talk!!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

// HELLO KITTY GUN

    public GameObject misskitty;

    public GameObject shootInstructions;

    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        introtxt.enabled = false;
        introtxtbox.enabled = false;
        introstructions.enabled = false;

        rightSprite.enabled = false;
        leftSprite.enabled = false;

        lname.enabled = false;
        rname.enabled = false;

        showcase.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        introdialogue();
    }

    private void OnTriggerEnter2D(Collider2D other){ // IF player enters trigger , 
        if (other.gameObject.name == "player"){
            Debug.Log("INTRODUCTIONS.... "); // lmk <3
            introTALK = true; // ENABLE ..
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }
    void introdialogue(){
        if (introTALK && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("intro time...");

        // DIALOGUE MANAGEMENT
            introtxtbox.enabled = true;
            introtxt.enabled = true;
            introstructions.enabled = true;
            introtxt.text = dialogueLines[currentLine];
            talkYES.SetActive(false); // deactivates the SIGNAL

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if(BISCTROchat == 0){
                rightSprite.enabled = true;
                rightSprite.sprite = b3;
                rname.enabled = true;
                rname.sprite = bisctag;
                
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    Debug.Log("onward to 2");
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 1){
                rightSprite.sprite = b1;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 2){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 3){
                showcase.enabled = true;
                rightSprite.sprite = b2;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 4){
                rightSprite.sprite = b1;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 5){
                showcase.enabled = false;
                rightSprite.sprite = b3;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 6){
                rightSprite.sprite = b2;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 7){
                rightSprite.sprite = b2;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 8){
                rightSprite.sprite = b3;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 9){
                rightSprite.sprite = b1;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 10){
                rightSprite.sprite = r1;
                rname.sprite = ruoktag;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 11){
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 12){
                rightSprite.sprite = b1;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 13){
                rightSprite.sprite = r1;
                if(Input.GetKeyDown(KeyCode.K)){ // if player presses K, 
                    BISCTROchat += 1; // next part
                    currentLine++; // next dialogue
                }
            } else if (BISCTROchat == 14){
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                introTALK = false;
                introtxt.enabled = false;
                introtxtbox.enabled = false;
                introstructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                // RESET
                currentLine = 0;

                // DESTROY ... ACTIVATE
                Destroy(gameObject);
                misskitty.SetActive(true);
                shootInstructions.SetActive(true);


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
            introTALK = false;
            talkYES.SetActive(false); // deactivates the SIGNAL
        }
    }
}
