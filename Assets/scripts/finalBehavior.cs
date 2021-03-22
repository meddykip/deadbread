using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalBehavior : MonoBehaviour
{
    bool thankyou;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalManage();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            thankyou = true;
        }
    }

    void finalManage(){
        if (thankyou){
            SceneManager.LoadScene("thanks");
            Debug.Log("END!!!");
        }
    }
}
