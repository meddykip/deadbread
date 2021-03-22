using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourOHfour : MonoBehaviour
{

// UI TINGZ
    public Image txtbox404; // the txtbox
    public Text txt404; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

// MANAGES THE VISUALS
    public float chat404; // takes note of the dialogue #
    public bool talk404; // talking to 404 ... CONFIRMED!?!

    public bool aftertalk404; // repeat sequence...!
    public GameObject spriteHOLDER; // holds the sprite !
    
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
            spriteHOLDER.SetActive(true); // activate the SPRITE
            talkYES.SetActive(false); // deactivates the SIGNAL
            txt404.enabled = true; // activate the TXT
            instructions.enabled = true; // activate the INSTRUCTION
            txtbox404.enabled = true; // activate the TXTBOX
            txt404.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
        
        // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carn404.GetComponent<playerBehavior>().carnMOVE = false;
            carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            
            if (chat404 == 0){ // PT.1
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 1){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 2){ // SHORTCUT FOR PLAYTEST
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 = 34;
                    currentLine = 34;
                }
            } else if (chat404 == 3){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 4){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 5){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 6){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 7){
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
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 11){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 12){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 13){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 14){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 15){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 16){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 17){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 18){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 19){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 20){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 21){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 22){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 23){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 24){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 25){
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
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 28){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 29){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 30){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 31){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 32){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 33){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 34){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 35){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 36){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 37){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 38){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 39){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 40){
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 41){
                Debug.Log("TEST11");
                if (Input.GetKeyDown(KeyCode.K)){
                    Debug.Log("END CONVO");
                    talk404 = false;
                    txt404.enabled = false;
                    spriteHOLDER.SetActive(false);
                    txtbox404.enabled = false;
                    instructions.enabled = false;

                    currentLine = 41;
                    chat404 = 42;

                // MOVEMENT RELATED
                    carn404.GetComponent<playerBehavior>().carnMOVE = true;
                    carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                    carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            } else if (chat404 == 42){
                Debug.Log("TEST1");
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            } else if (chat404 == 43){
                Debug.Log("TEST111");
                if (Input.GetKeyDown(KeyCode.K)){
                    chat404 += 1;
                    currentLine++;
                }
            }  else if (chat404 == 44){
                Debug.Log("END CONVO");
                talk404 = false;
                txt404.enabled = false;
                spriteHOLDER.SetActive(false);
                txtbox404.enabled = false;
                instructions.enabled = false;

                chat404 = 42;
                currentLine = 41;

            // MOVEMENT RELATED
                carn404.GetComponent<playerBehavior>().carnMOVE = true;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carn404.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }

        if (currentLine >= dialogueLines.Length){
            
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
