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

    public Animator movie;

//REFERENCES to components
    public Rigidbody2D myBody;
    BoxCollider2D myCollider;

// SPRITES !!
    SpriteRenderer myRenderer;

// INVENTORY

    public Image slot1;
    public Image slot2;

        // SPRITES

        public Sprite blank;
        public Sprite hkgun;
        public Sprite cookey;
        public Sprite pastryKEY;
        public Sprite ichigomilk;

    public GameObject nuelbeloved;
    public GameObject omubeloved;
    public GameObject grudgebeloved;
// KEYNVENTORY

    public Image kh1;
    public Image kh2;
    public Image kh3;
    public Image kh4;

        // SPRITES

        public Sprite fofkey;
        public Sprite dkey;
        public Sprite akey;
        public Sprite bkey;

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
    public GameObject unmanifest4;

    public GameObject unmanifest5;

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
        movie = GetComponent<Animator>();

    // INVENTORY 

        nuelbeloved.GetComponent<fourOHfour>(); // nuel's object + script
        omubeloved.GetComponent<omuBehavior>();
        grudgebeloved.GetComponent<strawberryBehavior>();

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
        if (Input.GetKeyDown(KeyCode.Space) && c_shoot.shootSpeed == 0 && kittygun){
            movie.SetBool("shoot", true);
            c_shoot.OnShoot();
        } else {
            movie.SetBool("shoot", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && c_shoot.shootSpeed > -1 && kittygun){
            movie.SetBool("shoot", true);
            c_shoot.OnShoot();
        } else {
            movie.SetBool("shoot", false);
        }

        kingdomHearts(); // to allow opening the door ,
        checkBUN(); // allows the checking >:)
        grudgemilk();
        cookiemilk();
        pantrymilk();
    }

    // checks what keys the player is pressing
    void ChecKeys(){
        if(Input.GetKey(KeyCode.D)){ // IF the player presses D , default direction
            moveDir = 1; // move forward !
            faceRight = true; // confirms direction
            myRenderer.flipX = true; // keeps the sprite direction
            movie.SetBool("walk", true);
        } else if (Input.GetKey(KeyCode.A)){ // ELSE if the player presses A
            moveDir = -1; // go back ,
            faceRight = false; // unfinals the fantasy ,
            myRenderer.flipX = false; // flips the sprite !
            movie.SetBool("walk", true);
        } else {
            movie.SetBool("walk", false);
            movie.SetBool("idle", true);
            moveDir = 0;
        }

        if(Input.GetKey(KeyCode.W) && onFloor){ // IF the player presses W,
            Debug.Log("WROW");
            movie.SetBool("jump", true);
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
            movie.SetBool("jump", false);
            onFloor = true; // walking CONFIRMED ...
        }
        
    // KEY CODES ...!
        if (collisionInfo.gameObject.name == "key404"){ // IF the player collides with the key ,
            Destroy(key404GET); // absorb the key
            Debug.Log("404 KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
            kh1.sprite = fofkey;
        } 
        if (collisionInfo.gameObject.name == "keyART"){
            Destroy(keyartGET); // absorb the key
            Debug.Log("ART KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
            kh2.sprite = akey;
        }
        if (collisionInfo.gameObject.name == "keyDIA"){
            Destroy(keydiaGET); // absorb the key
            Debug.Log("DIA KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
            diaTALK = true;
            kh3.sprite = dkey;
        }
        if (collisionInfo.gameObject.name == "keyBISCUIT"){
            Destroy(keybiscuitGET); // absorb the key
            Debug.Log("BISCUIT KEY GET!!!!"); // lmk !
            VISIONkeys += 1;
            kh4.sprite = bkey;
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
            slot1.sprite = hkgun;
        }
    }

// to OPEN the DOOR !
    void kingdomHearts(){
        if (VISIONkeys >= 4){ // IF player collects all the keys ...
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
        } else if (other.gameObject.name == "button4"){
            Destroy(unmanifest4);
        }  else if (other.gameObject.name == "button5"){
            Destroy(unmanifest4);
        } 

    // to enable KAORU PUZZLE ...
        if (other.gameObject.name == "kaoru"){
            checkBUN();
        }

    
    // STRAWBERRY MILK PUZZLE ...   

        if (other.gameObject.name == "milk"){
            milk.GetComponent<milkBehavior>().milktalk = true;
            milk.GetComponent<milkBehavior>().talkYES.SetActive(true);
        } else if (other.gameObject.name == "chocolate"){
            choco.GetComponent<chocoBehavior>().chocotalk = true;
            choco.GetComponent<chocoBehavior>().talkYES.SetActive(true);
        } else if (other.gameObject.name == "strawberry"){
            strawberry.GetComponent<strawberryBehavior>().strawberrytalk = true;
            strawberry.GetComponent<strawberryBehavior>().talkYES.SetActive(true);
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

    void pantrymilk(){
        if (nuelbeloved.GetComponent<fourOHfour>().pantryKEY && !omubeloved.GetComponent<omuBehavior>().cookierun && !grudgebeloved.GetComponent<strawberryBehavior>().milkGET){
            slot2.sprite = pastryKEY;
        } else if (!nuelbeloved.GetComponent<fourOHfour>().pantryKEY && !omubeloved.GetComponent<omuBehavior>().cookierun && !grudgebeloved.GetComponent<strawberryBehavior>().milkGET){
            slot2.sprite = blank;
        }
    }

    void cookiemilk(){
        if(omubeloved.GetComponent<omuBehavior>().cookierun && !grudgebeloved.GetComponent<strawberryBehavior>().milkGET && !nuelbeloved.GetComponent<fourOHfour>().pantryKEY){
            slot2.sprite = cookey;
        } else if (!omubeloved.GetComponent<omuBehavior>().cookierun && !grudgebeloved.GetComponent<strawberryBehavior>().milkGET && !nuelbeloved.GetComponent<fourOHfour>().pantryKEY){
            slot2.sprite = blank;
        }
    }

    void grudgemilk(){
        if(grudgebeloved.GetComponent<strawberryBehavior>().milkGET && !nuelbeloved.GetComponent<fourOHfour>().pantryKEY && !omubeloved.GetComponent<omuBehavior>().cookierun){
            slot2.sprite = ichigomilk;
        } else if (!grudgebeloved.GetComponent<strawberryBehavior>().milkGET && !nuelbeloved.GetComponent<fourOHfour>().pantryKEY && !omubeloved.GetComponent<omuBehavior>().cookierun){
            slot2.sprite = blank;
        }
    }
    void OnTriggerExit2D(Collider2D other){
    // to easily DISABLE milk dialogues
        if (other.gameObject.name == "milk"){

            milk.GetComponent<milkBehavior>().milktalk = false;
            milk.GetComponent<milkBehavior>().talkYES.SetActive(false);

        } else if (other.gameObject.name == "chocolate"){

            choco.GetComponent<chocoBehavior>().chocotalk = false;
            choco.GetComponent<chocoBehavior>().talkYES.SetActive(false);

        } else if (other.gameObject.name == "strawberry"){

            strawberry.GetComponent<strawberryBehavior>().strawberrytalk = false;
            strawberry.GetComponent<strawberryBehavior>().talkYES.SetActive(false);
        }
    }
}
