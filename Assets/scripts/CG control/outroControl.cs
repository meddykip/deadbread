using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class outroControl : MonoBehaviour
{
    public Sprite outro_1, outro_2, outro_3;
    public GameObject mainOutro;
    public float outroCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        outroManage();
    }

    void outroManage(){
        if (outroCount == 0){
            Debug.Log("PART ONE OF STORY");
            mainOutro.transform.GetComponent<UnityEngine.UI.Image>().sprite = outro_1;

            if (Input.GetKeyDown(KeyCode.RightArrow)){
                outroCount += 1;
                Debug.Log("1");
            }
        } else if (outroCount == 1){
            Debug.Log("PART TWO OF STORY");
            mainOutro.transform.GetComponent<UnityEngine.UI.Image>().sprite = outro_2;
            
            if (Input.GetKeyDown(KeyCode.RightArrow)){
                outroCount += 1;
                Debug.Log("2");
            }
        } else if (outroCount == 2){
            mainOutro.transform.GetComponent<UnityEngine.UI.Image>().sprite = outro_3;
            
            if (Input.GetKeyDown(KeyCode.RightArrow)){
                reStart();
            }
        }
    }

    public void reStart(){
        SceneManager.LoadScene("menu");
        Debug.Log("RESTART!!!");
    }
}
