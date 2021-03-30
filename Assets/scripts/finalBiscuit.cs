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

    // SPRITES
    public Image leftSprite; // holds the sprite !
    public Image rightSprite;

    public Image lname;
    public Image rname;

        // SPRITES  

        public Sprite ruokitag;
        public Sprite carntag;
        public Sprite bisctag;

        public Sprite b1;
        public Sprite b2;
        public Sprite b3;

        public Sprite r1;
        public Sprite r2;
        public Sprite c1;
        public Sprite c2;
        public Sprite c3;
        public Sprite c4;
        public Sprite c5;

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
    
        rightSprite.enabled = false;
        rname.enabled = false;
        leftSprite.enabled = false;
        lname.enabled = false;

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
        if (other.gameObject.name == "player"){
            Debug.Log("final fantasy...");
            finalTALK = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
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


        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if (FINALchat == 0){
                leftSprite.enabled = true;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.sprite = c1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 1){
                lname.enabled = false;
                rname.enabled = true;
                rname.sprite = bisctag;
                rightSprite.enabled = true;
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 2){
                rightSprite.sprite = b1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 3){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.sprite = c1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 4){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = b2;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 5){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 6){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 7){
                rightSprite.sprite = b1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 8){
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 9){
                rightSprite.sprite = b1;
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
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 12){
                rname.sprite = ruokitag;
                rightSprite.sprite = r1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 13){
                rightSprite.sprite = r2;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 14){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c2;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 15){
                leftSprite.sprite = c3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 16){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = r1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 17){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = bisctag;
                leftSprite.sprite = b1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 18){
                leftSprite.sprite = c2;
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = r1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 19){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.sprite = c5;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 20){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = b1;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 21){
                leftSprite.sprite = c4;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 22){
                rightSprite.sprite = b3;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 23){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c4;
                if (Input.GetKeyDown(KeyCode.K)){
                    FINALchat += 1;
                    currentLine++;
                }
            } else if (FINALchat == 24){
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = b3;
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
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                lname.enabled = false;
                rname.enabled = false;

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
