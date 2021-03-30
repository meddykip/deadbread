using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class carnHealth : MonoBehaviour
{
    
    // HEALTH MANAGEMENT
    public float baseHealth;

// HEALTH VISUALS
    public Slider health; // assigns the UI holding the bar , 

    [SerializeField]
    public float currentHealth; // shows current health , 

    public GameObject monbeloved;

    public Image status;
    public Sprite full;
    public Sprite low;
    public Sprite hit;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = baseHealth;
        monbeloved.GetComponent<monletBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        health.value = currentHealth;
        unpog();
    }

void OnTriggerEnter2D (Collider2D other){
    if (other.gameObject.name == "monlet"){
        Debug.Log("ahh");
    }
}

    void unpog(){    

        if (currentHealth <= 0){
            status.sprite = low;
        }
    }
}
