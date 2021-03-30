using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class monBehavior : MonoBehaviour
{

    // BOSS FIGHT CODE  ...
    public float speed;  // how fast mon moves ,
    public float stoppingDistance; // distance in which mon will NOT move ,
    public float retreatDistance; // distance in which mon will MOVE away

    private float timeBTWshots; // time in between shooting
    public float startTimeBTWshots; // start time between shooting

    public GameObject projectile; // assigns mon's bullets >:( ...!!
    public Transform player; // assigns the target ...!!
    public Transform wall;

    public SpriteRenderer myrend;

    // FINAL KEY 
    public GameObject keyLAST;

    // DIALOGUE CODE ...
    bool MONtalk; // to talk to mon ...
    public bool MONafterfight = false; // to talk to mon after the fight ...

    // MOVEMENT CODE ...
    //Rigidbody2D rbody; // references the object's rigidbody >:) 
    public GameObject carnbeloved; // references carn's script to control their voids !!

    public bool MONfight = false; // CONFIRMS if in fight or not...

    // DIALOGUE UI TINGZ
    public Image MONtxtbox; // the txtbox
    public Text MONtxt; // the txt IN the txtbox

    public Image instructions; // the txt that shows how to progress

    public Image leftSprite; // holds the sprite !
    public Image rightSprite;

    public Image lname;
    public Image rname;

    // SPRITES  

    public Sprite bisctag;
    public Sprite carntag;
    public Sprite montag;
    public Sprite ruoktag;

    public Sprite r1;
    public Sprite b1;
    public Sprite b2;
    public Sprite b3;
    public Sprite m1;
    public Sprite m2;
    public Sprite m3;
    public Sprite m4;
    public Sprite c1;
    public Sprite c2;

    //ETC SPRITES
    public Sprite run;
    public Sprite normal;
    public Sprite kill;

    // MANAGES THE DIALOGUE VISUALS
    public float MONchat; // conversation manager !!!
    public float MONfinalchat; // AFTER FIGHT conversation manager !!!

    // DIALOGUE TXT
    public string[] dialogueLines; // txt my beloved
    public int currentLine; // takes note of the dialogue #

    // SPRITES ...
    public GameObject MONsprite; // holds the sprite !

    public GameObject leftsprite;

    // Start is called before the first frame update
    void Start()
    {

        // DIALOGUE UI
        // they are hidden until triggered ...
        MONtxt.enabled = false;
        MONtxtbox.enabled = false;
        instructions.enabled = false;

        rightSprite.enabled = false;
        rname.enabled = false;
        leftSprite.enabled = false;
        lname.enabled = false;

        // FIGHTING CODE RELATED
        player = GameObject.FindGameObjectWithTag("Player").transform; // assigns the player
        wall = GameObject.Find("door").transform; // assigns the player
        timeBTWshots = startTimeBTWshots; // assigns the time between shots


        // MOVEMENT RELATED
        // assigns necessary tingz to control the movement
        //rbody = GetComponent<Rigidbody2D>(); // mon's rigidbody
        carnbeloved.GetComponent<playerBehavior>(); // carn's object + script
        myrend = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        MONdialogue(); // to call the dialogue EVENT

        if (MONfight)
        { // if in FIGHT...
            myrend.sprite = kill;
            // BULLET CODE + MON MOVING/CHASING PLAYER CODE
            // from this video: https://youtu.be/_Z1t7MNk0c4

            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;

            }
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance && Vector2.Distance(transform.position, wall.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

            }

            if (timeBTWshots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBTWshots = startTimeBTWshots;
            }
            else
            {
                timeBTWshots -= Time.deltaTime;
            }
        }
    }

    // TRIGGER CODE ...
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        { // if player steps on the trigger , 
            Debug.Log("MON FOUND"); // lmk that mon talking range >:)
            MONtalk = true; // you can talk to mon !
        }
    }

    // MON DIALOGUE CODE (before fight)
    void MONdialogue()
    {
        if (MONtalk && !MONfight && !MONafterfight)
        { // if player can TALK to mon + NOT fighting , 
            Debug.Log("you are talking to him..."); // lmk <3

            // DIALOGUE MANAGEMENT
            MONsprite.SetActive(true); // activate the SPRITE
            MONtxt.enabled = true; // activate the TXT
            MONtxtbox.enabled = true; // activate the TXTBOX
            MONtxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
            instructions.enabled = true; // activate the INSTRUCTION

            // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if (MONchat == 0)
            { // PT. 1
                Debug.Log("FIRST PART OF CONVO");
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = montag;
                rightSprite.sprite = m1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to 2");
                    MONchat += 1; // next part
                    currentLine++; // next dialogue
                }
            }
            else if (MONchat == 1)
            { // PT. 2
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = bisctag;
                leftSprite.enabled = true;
                leftSprite.sprite = b2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 2)
            { // PT. 2
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.enabled = true;
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 3)
            {

                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 4)
            {
                rname.enabled = false;
                leftSprite.sprite = b1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 5)
            {
                lname.sprite = ruoktag;
                leftSprite.sprite = r1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 6)
            {
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 7)
            {
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 8)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 9)
            {
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.sprite = c1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 10)
            {
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = m1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 11)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 12)
            {
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 13)
            {
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.sprite = c1;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 14)
            {

                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 15)
            {
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 16)
            {
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 17)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 18)
            {

                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 19)
            {
                rightSprite.sprite = m4;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 20)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K,
                    Debug.Log("onwards");
                    MONchat += 1;
                    currentLine++;
                }
            }
            else if (MONchat == 21)
            {

                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                MONtalk = false;
                MONtxt.enabled = false;
                MONsprite.SetActive(false);
                MONtxtbox.enabled = false;
                instructions.enabled = false;
                leftSprite.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;

                // fight START !!!
                currentLine = 0;
                MONfight = true;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }


        // AFTER fight dialogue
        if (MONafterfight)
        { // if fight is OVER , and mon is DEAD 

            // DIALOGUE MANAGEMENT
            MONsprite.SetActive(true); // activate the SPRITE
            MONtxt.enabled = true; // activate the TXT
            MONtxtbox.enabled = true; // activate the TXTBOX
            MONtxt.text = dialogueLines[currentLine]; // make sure the TXT presents the DIALOGUE
            instructions.enabled = true; // activate the INSTRUCTION

            // MOVEMENT MANAGEMENT
            // player CANNOT move ,
            carnbeloved.GetComponent<playerBehavior>().carnMOVE = false;
            carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            if (MONfinalchat == 0)
            { // PT. 1
                rightSprite.enabled = true;
                rname.enabled = true;
                rname.sprite = montag;
                rightSprite.sprite = m2;
                currentLine = 23;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onwards");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 1)
            { // PT. 2
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 2)
            { // PT. 2
                rightSprite.sprite = m4;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 3)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 4)
            {
                rname.enabled = false;
                lname.enabled = true;
                lname.sprite = carntag;
                leftSprite.enabled = true;
                leftSprite.sprite = c2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 5)
            {
                lname.enabled = false;
                rname.enabled = true;
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 6)
            {
                
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 7)
            {
                rightSprite.sprite = m2;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 8)
            {
                rightSprite.sprite = m3;
                if (Input.GetKeyUp(KeyCode.K))
                { // if player presses K, 
                    Debug.Log("onward to KEY GIVING");
                    MONfinalchat += 1; // next part
                    currentLine++; // next dialogue
                }

            }
            else if (MONfinalchat == 9)
            { // LAST PT.
                // END CONVERSATION
                Debug.Log("END CONVO");

                // DISABLES CONVO VISUALS ,
                MONtalk = false;
                MONtxt.enabled = false;
                MONsprite.SetActive(false);
                MONtxtbox.enabled = false;
                instructions.enabled = false;
                leftSprite.enabled = false;
                rightSprite.enabled = false;
                rname.enabled = false;
                lname.enabled = false;

                // DISABLES everything
                currentLine = 0;
                MONtalk = false;
                MONafterfight = true;

                // player can move :)
                carnbeloved.GetComponent<playerBehavior>().carnMOVE = true;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.None;
                carnbeloved.GetComponent<playerBehavior>().myBody.constraints = RigidbodyConstraints2D.FreezeRotation;

                keyLAST.SetActive(true);
                Destroy(gameObject);
            }
        }

        if (currentLine >= dialogueLines.Length)
        {

        }

    }
}
