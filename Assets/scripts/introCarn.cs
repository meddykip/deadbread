using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class introCarn : MonoBehaviour
{
    // to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool carnINTRO = false;

// DIALOGUE UI TINGZ
    public Image introtxtbox; // the txtbox
    public Text introtxt; // the txt IN the txtbox

    public Image introstructions; // txt progression instructions

    // SPRITE PLACEMENTS
    public Image rightSprite;
    public Image leftSprite;

    public Image rname;
    public Image lname;

        // SPRITES
        public Sprite ruokitag;
        public Sprite carntag;
        public Sprite bisctag;

        public Sprite carn1;
        public Sprite b1;
        public Sprite b2;
        public Sprite b3;
        public Sprite r1;

    // MANAGES THE DIALOGUE VISUALS
    public float CARNTROchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #
    public GameObject talkYES; // SIGNAL that says u can talk!!!

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    
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

        rname.enabled = false;
        lname.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        carntrodialogue();
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "player"){
            carnINTRO = true;
            talkYES.SetActive(true);
        }
    }

    void carntrodialogue(){
        if (carnINTRO && Input.GetKeyDown(KeyCode.K)){
            Debug.Log("intro time...");

        // DIALOGUE MANAGEMENT
            introtxtbox.enabled = true;
            introtxt.enabled = true;
            introstructions.enabled = true;
            introtxt.text = dialogueLines[currentLine];
            leftSprite.enabled = true;

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if (CARNTROchat == 0){
                leftSprite.sprite = carn1;
                lname.enabled = true;
                lname.sprite = carntag;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            } else if (CARNTROchat == 1){
                lname.enabled = false;
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = ruokitag;
                rightSprite.sprite = r1;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 2){
                rightSprite.sprite = b1;
                rname.sprite = bisctag;
                leftSprite.enabled = false;
                lname.enabled = false;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 3){
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 4){
                leftSprite.enabled = true;
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 5){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = b2;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 6){
                rightSprite.sprite = b1;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 7){
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            }  else if (CARNTROchat == 8){
                rightSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = true;
                if (Input.GetKeyDown(KeyCode.K)){
                    CARNTROchat += 1;
                    currentLine++;
                }
            } else if (CARNTROchat == 9){
                // END CONVERSATION
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    carnINTRO = false;
                    introtxt.enabled = false;
                    introtxtbox.enabled = false;
                    introstructions.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;

                    // RESET
                    currentLine = 0;

                    // DESTROY ... ACTIVATE
                    Destroy(gameObject);


                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
