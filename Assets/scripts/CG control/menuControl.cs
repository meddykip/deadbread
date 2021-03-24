using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{

    //public void playIntro() {
       // SceneManager.LoadScene("intro_cutscene");
       // Debug.Log("STORYTIME");
    //}

    void Start(){

    }

    void Update(){
    if (Input.GetKeyDown(KeyCode.RightArrow)){
            playIntro();
        }
    }

    public void playIntro(){
        SceneManager.LoadScene("intro_cutscene");
    }

}
