using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruokiTrigger : MonoBehaviour
{

    public bool ruokichat;

    public GameObject NYACTIVATE;

    public GameObject talkYES; // SIGNAL that says u can talk!!!

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ruokonvo();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("clown enter..");
            ruokichat = true;
            talkYES.SetActive(true); // shows the SIGNAL !
        }
    }

    void ruokonvo(){
        if (ruokichat && Input.GetKeyDown(KeyCode.K)){
            NYACTIVATE.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Debug.Log("clown enter..");
            ruokichat = false;
            talkYES.SetActive(false); // shows the SIGNAL !
            NYACTIVATE.SetActive(false);
        }
    }
}
