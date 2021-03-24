using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
//PUBLIC tuning variables
    public float speed; //how fast the character moves
    public float jumpHeight; //how high the player can jump
    public float gravityMultiplier;
    public float jumpMultiplier;

//REFERENCES to components
    public Rigidbody2D myBody;
    BoxCollider2D myCollider;

// SPRITES !!
    SpriteRenderer myRenderer;

    public Sprite jumpSprite;
    public Sprite walkSprite;

//PRIVATE code + tunes
    float moveDir = 1;
    //by default the player will move right
    bool onFloor = true;
    public static bool faceRight = true;

// HELLO KITTY GUN

    public GameObject helloKitty;
    public bool kittygun = false;

// to UNMANIFEST the door stoppers ...!
    public GameObject unmanifest1;
    public GameObject unmanifest2;
    public GameObject unmanifest2_3;
    public GameObject unmanifest3;

// to COLLECT THE KEYS ...!
    public GameObject key404GET;
    public GameObject keyartGET;
    public GameObject keydiaGET;
    public GameObject keybiscuitGET;

    // for the DIAlogue,

    public bool diaTALK;

// to UNLOCK the door ..!
    public float VISIONkeys = 0;
    bool doorUNLOCK = false;

// to control MOVEMENT during dialogue ...
    public bool carnMOVE = true;

    private playerShoot c_shoot;

// OMU PUZZLE

public bool strawberrymilk = false;

public bool grudgeFRIEND = false;
public bool strawberryASK = false;

public GameObject ichimilk;

public GameObject barrier;

public GameObject choco; // to use variables from the choco script,
public GameObject milk; // to use variables from the milk script,
public GameObject strawberry; // to use variables from the strawberry script,


//KAORU PUZZLE
    public Image warningBOX;
    public Text warningTXT;
    public bool handsFULLoven = false; // so the player cant check more than one object all at once !!!
    public bool handsFULLtoast = false;

    public bool handsFULLstove = false;

    // to reference the objects involved in the puzzle !!
    public GameObject toast; // to use variables from the toast script , 

    public GameObject oven; // to use variables from the oven script , 

    public GameObject stove; // to use variables from the stove script ,

    // to trigger the right conversations

    public bool RIGHTCHOICE = false;
    public bool WRONGCHOICE = false;

// Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myCollider = gameObject.GetComponent<BoxCollider2D>();
        myRenderer = gameObject.GetComponent<SpriteRenderer>();

    // KAORU PUZZLE
        c_shoot = GetComponent<playerShoot>();
        toast.GetComponent<toasterBehavior>();
        oven.GetComponent<ovenBehavior>();
        stove.GetComponent<stoveBehavior>();

        warningBOX.enabled = false;
        warningTXT.enabled = false;

    // MILK PUZZLE
        milk.GetComponent<milkBehavior>();
        choco.GetComponent<chocoBehavior>();
        strawberry.GetComponent<strawberryBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){ // runs first
        if (onFloor && myBody.velocity.y > 1){
            onFloor = false; // automatically false!
        }

    // to handle ALL player MOVEMENTS
        if (carnMOVE){
            ChecKeys();
            HandleMovement();
            JumpPhysics();
        }

    // for the SHOOTING code , 
        if (Input.GetKeyDown(KeyCode.Space) && c_shoot.shootSpeed == 0){
            c_shoot.OnShoot();
        }
        if (Input.GetKey(KeyCode.Space) && c_shoot.shootSpeed > -1){
            c_shoot.OnShoot();
        }

        kingdomHearts(); // to allow opening the door ,
        checkBUN(); // allows the checking >:)
        grudgemilk();
    }

    // checks what keys the player is pressing
    void ChecKeys(){
        if(Input.GetKey(KeyCode.D)){ // IF the player presses D , default direction
            moveDir = 1; // move forward !
            faceRight = true; // confirms direction
            myRenderer.flipX = true; // keeps the sprite direction
        } else if (Input.GetKey(KeyCode.A)){ // ELSE if the player presses A
            moveDir = -1; // go back ,
            faceRight = false; // unfinals the fantasy ,
            myRenderer.flipX = false; // flips the sprite !
        } else {
            moveDir = 0;
        }

        if(Input.GetKey(KeyCode.W) && onFloor){ // IF the player presses W,
            Debug.Log("WROW");
            myRenderer.sprite = jumpSprite;
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);
            // jumping movement !!!!

        } else if(!Input.GetKey(KeyCode.W) && myBody.velocity.y > 1){
            myBody.velocity += Vector2.up * Physics.gravity.y * (jumpMultiplier * 1f)* Time.deltaTime;
        }
    }

    // the jump code from the tutorial... :)
    void JumpPhysics(){
        if(myBody.velocity.y < 0){
            myBody.velocity += Vector2.up * Physics.gravity.y * (gravityMultiplier - 1f) * Time.deltaTime;
        }
    }

    // code to handle movement from the tutorial... :)
    void HandleMovement(){
        myBody.velocity = new Vector3(moveDir * speed, myBody.velocity.y);
    }

// PURE COLLISION code...!
    void OnCollisionEnter2D(Collision2D collisionInfo){
        if(collisionInfo.gameObject.tag == "floor"){ // IF the player collides with the floor , 
            myRenderer.sprite = walkSprite; // sprite = walk sprite
            onFloor = true; // walking CONFIRMED ...
        }
        
    // KEY CODES ...!
        if (collisionInfo.gameObject.name == "key404"){ // IF the player collides with the key ,
            Destroy(key404GET); // absorb the key
            Debug.Log("404 KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
        } 
        if (collisionInfo.gameObject.name == "keyART"){
            Destroy(keyartGET); // absorb the key
            Debug.Log("ART KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
        }
        if (collisionInfo.gameObject.name == "keyDIA"){
            Destroy(keydiaGET); // absorb the key
            Debug.Log("DIA KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
            diaTALK = true;
        }
        if (collisionInfo.gameObject.name == "keyBISCUIT"){
            Destroy(keybiscuitGET); // absorb the key
            Debug.Log("BISCUIT KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
        }

        if (collisionInfo.gameObject.tag == "door" && doorUNLOCK){ // IF the player has the key + collides with the door
            Destroy(collisionInfo.gameObject); // kick the door down for BINGUS ...
            Debug.Log("no more door"); // the evil is defeated
        }

        if(collisionInfo.gameObject.tag == "enemy"){ // IF the player collides with the enemy ,
            Debug.Log("OOF"); // just lmk <3
        }

        if (collisionInfo.gameObject.name == "hellokitty"){
            kittygun = true;
        }
    }

// to OPEN the DOOR !
    void kingdomHearts(){
        if (VISIONkeys == 4){ // IF player collects all the keys ...
         doorUNLOCK = true; // you can unlock the door !! :)
        }
    }

// KAORU PUZZLE
    void checkBUN(){
        if (Input.GetKeyDown(KeyCode.K)){

            if(toast.GetComponent<toasterBehavior>().AVAILABLEtoast && toast.GetComponent<toasterBehavior>().wrongBUN){

                Debug.Log("WRONGBUN"); // lmk its wrong <3
                toast.GetComponent<toasterBehavior>().AVAILABLEtoast = false; // you can no longer check afterwards !!

            // CLOSE THE WARNING BOXES
                warningBOX.enabled = false;
                warningTXT.enabled = false;
            
            // ENABLE THE OTHERS
                // the player can check them now ..!
                oven.GetComponent<ovenBehavior>().AVAILABLEoven = true;
                stove.GetComponent<stoveBehavior>().AVAILABLEstove = true;

            // no longer with toast ...
                handsFULLtoast = false;
                toast.GetComponent<toasterBehavior>().CLICKABLE = false;
                WRONGCHOICE = true;
            } else if (stove.GetComponent<stoveBehavior>().AVAILABLEstove && stove.GetComponent<stoveBehavior>().wrongBUN_stove){

                Debug.Log("WRONGBUN STOVE EDITION"); // lmk <3
                stove.GetComponent<stoveBehavior>().AVAILABLEstove = false;
                oven.GetComponent<ovenBehavior>().AVAILABLEoven = true;

            // CLOSE THE WARNING BOXES
                warningBOX.enabled = false;
                warningTXT.enabled = false;

            // no longer with stove ...
                handsFULLstove = false;
                stove.GetComponent<stoveBehavior>().CLICKABLE_stove = false;
                WRONGCHOICE = true;
            } else if (oven.GetComponent<ovenBehavior>().AVAILABLEoven && oven.GetComponent<ovenBehavior>().rightBUN){

                Debug.Log("RIGHTBUN"); // correct !!
            
            // player can NO longer check !!
                oven.GetComponent<ovenBehavior>().AVAILABLEoven = false;
                stove.GetComponent<stoveBehavior>().AVAILABLEstove = false;
                toast.GetComponent<toasterBehavior>().AVAILABLEtoast = false;
            
            // CLOSE THE WARNING BOXES
                warningBOX.enabled = false;
                warningTXT.enabled = false;

            // no longer with oven ...
                handsFULLoven = false;
                RIGHTCHOICE = true;
            }
        }
    }

// COLLISION (but TRIGGER) code...!
    void OnTriggerEnter2D(Collider2D other){
    // KEY CODES ...
        if (other.gameObject.name == "button1"){ // IF the player triggers the buttons ,
            Destroy(unmanifest1); // destroy the doorstops
        } else if (other.gameObject.name == "button2"){
            Destroy(unmanifest2);
        } else if (other.gameObject.name == "button2_3"){
            Destroy(unmanifest2_3);
        } else if (other.gameObject.name == "button3"){
            Destroy(unmanifest3);
        }

    // to enable KAORU PUZZLE ...
        if (other.gameObject.name == "kaoru"){
            checkBUN();
        }

    
    // STRAWBERRY MILK PUZZLE ...   

        if (other.gameObject.name == "milk"){
            milk.GetComponent<milkBehavior>().milktalk = true;
        } else if (other.gameObject.name == "chocolate"){
            choco.GetComponent<chocoBehavior>().chocotalk = true;
        } else if (other.gameObject.name == "strawberry"){
            strawberry.GetComponent<strawberryBehavior>().strawberrytalk = true;
        }

        if (other.gameObject.name == "ichigomilk"){
            Destroy(ichimilk);
            strawberrymilk = true;
        }

        if (other.gameObject.name == "barTrigger"){
            if (strawberrymilk){
                barrier.SetActive(true);
            } else {
                barrier.SetActive(false);
            }
        }
    }

    void grudgemilk(){
        if(grudgeFRIEND){
            barrier.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D other){
    // to easily DISABLE milk dialogues
        if (other.gameObject.name == "milk"){

            milk.GetComponent<milkBehavior>().milktalk = false;

        } else if (other.gameObject.name == "chocolate"){

            choco.GetComponent<chocoBehavior>().chocotalk = false;

        } else if (other.gameObject.name == "strawberry"){

            strawberry.GetComponent<strawberryBehavior>().strawberrytalk = false;

        }
    }
}
