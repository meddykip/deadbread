using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class kittyGUN : MonoBehaviour
{
// to easily ACTIVATE or DEACTIVATE CONVERSATION
    bool kittygunTALK = false;

// DIALOGUE UI TINGZ
    public Image kittyguntxtbox; // the txtbox
    public Text kittyguntxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image showcase;
    public Image leftSprite;
    public Image lname;

        //NAMETAG

        public Sprite carntag;
        public Sprite hkgun;
        public Sprite c1;
        public Sprite c2;

// MANAGES THE DIALOGUE VISUALS
    public float KITTYGUNchat; // conversation manager !!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

// CONTROL PLAYER MOVEMENT

    public GameObject carnbeloved;

    public GameObject shoot;
    
    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI
        // they are hidden until triggered ...
        kittyguntxt.enabled = false;
        kittyguntxtbox.enabled = false;
        instructions.enabled = false;
        showcase.enabled = false;

        leftSprite.enabled = false;
        lname.enabled = false;

    // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        kittygundialogue();
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "player"){
            Debug.Log("violence");
            kittygunTALK = true;
        }
    }

    void kittygundialogue(){
        if(kittygunTALK){
            Debug.Log("hellokitty time...");

        // DIALOGUE MANAGEMENT
            kittyguntxtbox.enabled = true;
            kittyguntxt.enabled = true;
            instructions.enabled = true;
            kittyguntxt.text = dialogueLines[currentLine];

        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
            if(KITTYGUNchat == 0){
                Debug.Log("gh");
                showcase.enabled = true;
                showcase.sprite = hkgun;
                if(Input.GetKeyDown(KeyCode.K)){
                    KITTYGUNchat += 1;
                    currentLine++;
                }
            } else if (KITTYGUNchat == 1){
                if(Input.GetKeyDown(KeyCode.K)){
                    KITTYGUNchat += 1;
                    currentLine++;
                }
            } else if (KITTYGUNchat == 2){
                showcase.enabled = false;
                leftSprite.enabled = true;
                leftSprite.sprite = c2;
                lname.enabled = true;
                lname.sprite = carntag;
                if(Input.GetKeyDown(KeyCode.K)){
                    KITTYGUNchat += 1;
                    currentLine++;
                }
            } else if (KITTYGUNchat == 3){
                if(Input.GetKeyDown(KeyCode.K)){
                    KITTYGUNchat += 1;
                    currentLine++;
                }
            }  else if  (KITTYGUNchat == 4){
                leftSprite.sprite = c1;
                if(Input.GetKeyDown(KeyCode.K)){
                    KITTYGUNchat += 1;
                    currentLine++;
                }
            } else if  (KITTYGUNchat == 5){
                    Debug.Log("END CONVO");

                    // DISABLES CONVO VISUALS ,
                    kittygunTALK = false;
                    kittyguntxt.enabled = false;
                    leftSprite.enabled = false;
                    lname.enabled = false;
                    kittyguntxtbox.enabled = false;
                    instructions.enabled = false;

                    Destroy(gameObject);
                    shoot.SetActive(true);

                    // player can move :)
                    carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
