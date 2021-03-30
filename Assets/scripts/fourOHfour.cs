using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourOHfour : MonoBehaviour
{

public bool pantryKEY;

// UI TINGZ
    public Image txtbox404; // the txtbox
    public Text txt404; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image showcase;

    public Image rightSprite;
    public Image leftSprite;

    public Image rname;
    public Image lname;

        // NAMETAG

        public Sprite carntag;
        public Sprite nueltag;

        // SPRITES

        public Sprite pantry;

        public Sprite c1;
        public Sprite c2;
        public Sprite c3;

        public Sprite n1;
        public Sprite n2;
        public Sprite n3;


// MANAGES THE VISUALS
    public float chat404; // takes note of the dialogue #
    public bool talk404; // talking to 404 ... CONFIRMED!?!

    public bool aftertalk404; // repeat sequence...!
    
    //public GameObject carnHOLDER;
    public GameObject talkYES; // SIGNAL that says u can talk!!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine;

// MANAGES MOVEMENT

    public GameObject carn404; // references carn's script to control their voids !!

    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI TINGZ
        // disabled until triggered by player ... 
        instructions.enabled = false;
        txt404.enabled = false;
        txtbox404.enabled = false;
        showcase.enabled = false;

        rightSprite.enabled = false;
        leftSprite.enabled = false;
        rname.enabled = false;
        lname.enabled = false;

    // PLAYER MOVEMENT RELATED
        carn404.GetComponent<playerBehavior>(); // carn's object + script
    }

    // Update is called once per frame
    void Update()
    {
        dialogue404();

    }

    private void OnTriggerEnter2D(Collider2D other){ // IF player enters trigger , 
        if(other.gameObject.name == "player"){

            Debug.Log("404 FOUND"); // 404 talking range >:)
            talk404 = true; // you can talk to 404 !
            talkYES.SetActive(true); // shows the SIGNAL !
            
        }
    }

// conversation with 404 ...!
    void dialogue404(){
        if(talk404 && Input.GetKeyDown(KeyCode.K)){ // IF talking confirmed + player presses K ,
            Debug.Log("hatsune miku"); // lmk <3
        
        //  VISUAL UI TINGZ !!
            talkYES.SetActive(false); // deactivates the SIGNAL
            txt404.enabled = true; // activate the TXT
            instructions.enabled = true; // activate the INSTRUCTION
            txtbox404.enabled = true; // activate the TXTBOX
        
        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carn404.GetComponent<playerBehavior>().carnMOVE = false;
            carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        
        if (!carn404.GetComponent<playerBehavior>().strawberryASK){
            txt404.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
            if (chat404 == 0){ // PT.1
                leftSprite.enabled = true;
                lname.enabled = true;
                leftSprite.sprite = c1;
                lname.sprite = carntag;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 1){
                lname.enabled = false;
	            rightSprite.enabled = true;
	            rname.enabled = true;
                rightSprite.sprite = n1;
                rname.sprite = nueltag;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 2){ 
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 3){
                rname.enabled = false;
                leftSprite.enabled = true;
                lname.enabled = true;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 4){
                rname.enabled = true;
                lname.enabled = false;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 5){
                lname.enabled = true;
                rname.enabled = false;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 6){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = n2;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 7){
                rightSprite.sprite = n1;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 8){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 9){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 10){
                if (Input.GetKeyDown(KeyCode.K)){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                leftSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;

                chat404 = 25;
                currentLine = 25;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } else if (chat404 == 25){
                rightSprite.enabled = true;
                rname.enabled = true;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 26){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 27){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                chat404 = 28;
                currentLine = 27;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (chat404 == 28){
                rightSprite.enabled = true;
                rname.enabled = true;
                rightSprite.sprite = n3;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 29){
                rightSprite.sprite = n2;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 30){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                chat404 = 25;
                currentLine = 25;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        } else if (carn404.GetComponent<playerBehavior>().strawberryASK){
            if (chat404 == 25 || chat404 == 28){
                rightSprite.sprite = n3;
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = nueltag;
                chat404 = 11;
                currentLine = 10;
                txt404.text = dialogueLines[currentLine]; 
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 12){
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.enabled = true;
                leftSprite.sprite = c3;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 13){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = n1;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 14){
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c2;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 15){
                Debug.Log("ACQUIRED");
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = n2;
                showcase.enabled = true;
                showcase.sprite = pantry;
                pantryKEY = true;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 16){
                rightSprite.sprite = n1;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 17){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 18){
                showcase.enabled = false;
                rname.enabled = false;
                lname.enabled = true;
                leftSprite.sprite = c3;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 19){
                rname.enabled = true;
                lname.enabled = false;
                rightSprite.sprite = n2;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++ ;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 20){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                leftSprite.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                chat404 = 21;
                currentLine = 24;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (chat404 == 21){
                rightSprite.enabled = true;
                rname.enabled = true;
                rightSprite.sprite = n1;
                rname.sprite = nueltag;
                txt404.text = dialogueLines[currentLine]; 
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 22){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 23){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                chat404 = 31;
                currentLine = 26;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            } else if (chat404 == 31){
                rightSprite.enabled = true;
                rname.enabled = true;
                rightSprite.sprite = n3;
                rname.sprite = nueltag;
                txt404.text = dialogueLines[currentLine]; 
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 32){
                rightSprite.sprite = n2;
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                    txt404.text = dialogueLines[currentLine]; 
                }
            } else if (chat404 == 33){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                txtbox404.enabled = false;
                instructions.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;

                chat404 = 21;
                currentLine = 25;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }  
        }
    }
}



    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("404 NOT FOUND");
            talk404 = false;
            talkYES.SetActive(false);
        }
    }
}
