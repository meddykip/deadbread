﻿using System.Collections;
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

// to UNLOCK the door ..!
    public float VISIONkeys = 0;
    bool doorUNLOCK = false;

// to control MOVEMENT during dialogue ...
    public bool carnMOVE = true;

    private playerShoot c_shoot;

//KAORU PUZZLE
    public Image warningBOX;
    public Text warningTXT;
    public bool handsFULLoven = false; // so the player cant check more than one object all at once !!!
    public bool handsFULLtoast = false;

    // to reference the objects involved in the puzzle !!
    public GameObject toast; // to use variables from the toast script , 

    public GameObject oven; // to use variables from the oven script , 

// Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myCollider = gameObject.GetComponent<BoxCollider2D>();
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        c_shoot = GetComponent<playerShoot>();
        toast.GetComponent<toasterBehavior>();
        oven.GetComponent<ovenBehavior>();

        warningBOX.enabled = false;
        warningTXT.enabled = false;
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
                Debug.Log("WRONGBUN");
                toast.GetComponent<toasterBehavior>().AVAILABLEtoast = false; // you can no longer check
                warningBOX.enabled = false;
                warningTXT.enabled = false;
                oven.GetComponent<ovenBehavior>().AVAILABLEoven = true;
                handsFULLtoast = false;
                toast.GetComponent<toasterBehavior>().CLICKABLE = false;
            } else if (oven.GetComponent<ovenBehavior>().AVAILABLEoven && oven.GetComponent<ovenBehavior>().rightBUN){
                Debug.Log("RIGHTBUN");
                oven.GetComponent<ovenBehavior>().AVAILABLEoven = false;
                warningBOX.enabled = false;
                warningTXT.enabled = false;
                oven.GetComponent<ovenBehavior>().key.SetActive(true);
                oven.GetComponent<ovenBehavior>().button.SetActive(true);
                handsFULLoven = false;
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
            Debug.Log("DIA KEY GET!!!!");
            Destroy(unmanifest3);
        }

    // to enable KAORU PUZZLE ...
        if (other.gameObject.name == "kaoru"){
            checkBUN();
        }

    }
}