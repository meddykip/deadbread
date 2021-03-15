using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // AUTO-DELETE CODE ...!
    void OnBecameInvisible(){ // if the beam is out of the screen , 
        Destroy(gameObject); // self distruct ... :)
    }

}
