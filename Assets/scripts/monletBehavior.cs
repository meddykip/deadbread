using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monletBehavior : MonoBehaviour
{
    // BULLET BEHAVIOR , follows the player !!
        // from this video: https://youtu.be/_Z1t7MNk0c4
        
    public float speed; // speed of bullet ...!

    private Transform player; // assigns the player ...
    private Vector2 target; // to set up where the beam should go >:O 


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // assign player with carn !!
        
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    
        if (transform.position.x == target.x && transform.position.y == target.y){ // IF the bullet gets to where it needs to go , 
            DestroyProjectile(); // self distruct ...
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){ // if the bullet hits CARN , 

            Debug.Log("CARN HIT????"); // lmk that carn is hit :(
            DestroyProjectile(); // destroy itself ...

        }
    }
    void DestroyProjectile(){
        Destroy(gameObject); // self distruct ... :)
    }

    // AUTO-DELETE CODE ...!
    void OnBecameInvisible(){ // if the beam is out of the screen , 
        Destroy(gameObject); // self distruct ... again :)
    }
}
