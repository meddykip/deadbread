using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

// MANAGE ENEMY HEALTH code 
    // from this tutorial: https://www.youtube.com/watch?v=qN9UzT_HXEw

// HEALTH MANAGEMENT
    public float baseHealth;

// HEALTH VISUALS
    public Image health; // assigns the UI holding the bar , 

    public Sprite full; // sprite when FULl hp , 
    
    public Sprite half; // sprite when HALF hp , 

    [SerializeField]
    float currentHealth; // shows current health , 

    public SpriteRenderer myrend;
    public Color dmg;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = baseHealth;
        myrend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float damage){

    // health is decreased by damage done in playerBehavior , 
        currentHealth -= damage;

        if (currentHealth == 6){ // IF currentHealth is max , 

            health.sprite = full; // use full health sprite !!!

        } else if (currentHealth <= 4){ // ELSE if currentHealth is half , 

            health.sprite = half; // use half health sprite !!!

        }
        if (currentHealth <= 0){ // IF currentHealth is 0 , 

            Destroy(gameObject); // then self distruct... :)

        }
    }

//  DEATH CODE ... !!!
    void Die(){
        Debug.Log("DEATH");
        currentHealth = baseHealth;
    }
}
