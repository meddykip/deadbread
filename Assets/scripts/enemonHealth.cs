using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class enemonHealth : MonoBehaviour
{
// MANAGE ENEMY ( specifically , mon ) HEALTH code 
    // from this tutorial: https://www.youtube.com/watch?v=qN9UzT_HXEw

// AFTER FIGHT DIALOGUE MANAGEMENT
public GameObject afterFight;

// HEALTH MANAGEMENT
    public float baseHealth;

// HEALTH VISUALS
    public Slider health; // assigns the UI holding the bar , 

    [SerializeField]
    float currentHealth; // shows current health , 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = baseHealth;
        afterFight.GetComponent<monBehavior>(); // assigns the object + script
        
    }

    // Update is called once per frame
    void Update()
    {
        health.value = currentHealth;
    }

    public void Damage(float damage){

    // health is decreased by damage done in playerBehavior , 
        currentHealth -= damage;

        if (currentHealth <= 0){ // IF currentHealth is 0 , 

        //AFTERFIGHT CUTSCENE
            Debug.Log("MON DEAD");// lmk !!!
            afterFight.GetComponent<monBehavior>().MONafterfight = true; // ACTIVATE the cutscene
            afterFight.GetComponent<monBehavior>().MONfight = false; // DEACTIVATE fight

        }
    }

//  DEATH CODE ... ???
    void Die(){
        Debug.Log("DEATH");
        currentHealth = baseHealth;
    }
}
