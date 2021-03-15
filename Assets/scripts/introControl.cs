using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introControl : MonoBehaviour
{

    public Sprite intro_1, intro_2, intro_3, intro_4, intro_5, intro_6;
    public GameObject mainIntro;
    public float introCount;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("STARTED");

    }

    // Update is called once per frame
    void Update()
    {
        introManage();
    }

    void introManage(){
        if (introCount == 1){
            Debug.Log("PART ONE OF STORY");
            mainIntro.transform.GetComponent<UnityEngine.UI.Image>().sprite = intro_1;

            if (Input.GetKeyDown(KeyCode.RightArrow)){
                introCount += 1;
                Debug.Log("NEXT PAGE");
            }
        } else if (introCount == 2){
            Debug.Log("PART TWO OF STORY");
            mainIntro.transform.GetComponent<UnityEngine.UI.Image>().sprite = intro_2;
            
            if (Input.GetKeyDown(KeyCode.RightArrow)){
                introCount += 1;
                Debug.Log("NEXT PAGE");
            }
        } else if (introCount == 3){
            Debug.Log("PART THREE OF STORY");
            mainIntro.transform.GetComponent<UnityEngine.UI.Image>().sprite = intro_3;
            
            if (Input.GetKeyDown(KeyCode.RightArrow)){
                playGame();
            }
        }
    }

    public void playGame(){
        SceneManager.LoadScene("game");
        Debug.Log("PLAY TIME CONFIRMED!!!");
    }
}
