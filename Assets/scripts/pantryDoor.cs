using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantryDoor : MonoBehaviour
{
    public bool OPEN;
    // TO CHECK IF CAN OPEN
    public GameObject nuelbeloved;
    public GameObject carnbeloved;
    // Start is called before the first frame update
    void Start()
    {
        nuelbeloved.GetComponent<fourOHfour>(); // nuel's object + script
    }

    // Update is called once per frame
    void Update()
    {
        teehee();
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "player"){
            OPEN = true;
        }
    }

    void teehee(){
        if (OPEN){
            if (nuelbeloved.GetComponent<fourOHfour>().pantryKEY){
                Destroy(gameObject);
                nuelbeloved.GetComponent<fourOHfour>().pantryKEY = false;
            }
        }
    }
}
