using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourOHfour : MonoBehaviour
{

// UI TINGZ
    public Image txtbox404; // the txtbox
    public Text txt404; // the txt IN the txtbox

    public Text instructions; // the txt that shows how to progress

// MANAGES THE VISUALS
    public float chat404; // takes note of the dialogue #
    public bool talk404; // talking to 404 ... CONFIRMED!?!
    public GameObject spriteHOLDER; // holds the sprite !
    public GameObject talkYES; // SIGNAL that says u can talk!!!

    public string[] dialogueLines; // txt my beloved
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
    // DIALOGUE UI TINGZ
        // disabled until triggered by player ... 
        instructions.enabled = false;
        txt404.enabled = false;
        txtbox404.enabled = false;
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
            spriteHOLDER.SetActive(true); // activate the SPRITE
            talkYES.SetActive(false); // deactivates the SIGNAL
            txt404.enabled = true; // activate the TXT
            instructions.enabled = true; // activate the INSTRUCTION
            txtbox404.enabled = true; // activate the TXTBOX
            txt404.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
        
            currentLine++;
        }

        if (currentLine >= dialogueLines.Length){
            Debug.Log("END CONVO");
            talk404 = false;
            txt404.enabled = false;
            spriteHOLDER.SetActive(false);
            txtbox404.enabled = false;

            currentLine = 0;
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
