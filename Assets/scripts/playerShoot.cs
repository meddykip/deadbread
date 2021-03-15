using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    public GameObject beam; // to Manifest a new object
    public Transform beamTip; // origin of the bullets

    public float shootSpeed; // kill speed >:)
    public float damage = 2f;

    public LayerMask victim; // layer affected by the beam
    public LayerMask mon; // layer affected by the beam
    public float range;

    public float hitForce;
    float timeFire = 0;

    public GameObject eneMON;

    // Start is called before the first frame update
    void Start()
    {
        eneMON.GetComponent<monBehavior>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void Awake(){

    }

// RAYCAST code 
    // from this tutorial: https://www.youtube.com/watch?v=qN9UzT_HXEw
    public void OnShoot(){ 
        if(shootSpeed == 0){
            shoot();
        } else{
            if (Time.time > timeFire){
                timeFire = Time.time + 1 / shootSpeed;
                shoot();
            }
        }
    }

    void shoot(){
        Vector2 firePos = new Vector2(beamTip.position.x, beamTip.position.y);

        Vector2 dir = (playerBehavior.faceRight) ? Vector2.right : Vector2.left;

        Debug.DrawRay(firePos, dir * range, Color.blue, 1f);

        shootRay(firePos, dir);

        drawBullet();
    }

    void shootRay(Vector2 origin, Vector2 direction){
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, range, victim); // assigns raycast for VICTIMS = regular enemies 
        RaycastHit2D hitmon = Physics2D.Raycast(origin, direction, range, mon); // assigns raycast for MON

        if (hit.collider != null){
            Debug.Log("VIOLENCE CHOSEN");

            // enemy dmg logic,
            hit.collider.gameObject.GetComponent<enemyHealth>().Damage(damage);

            if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null){
                //it has a rigidbody2D
                hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-hit.normal * hitForce);
            }
            
        } else if (hitmon.collider != null){

            // mon dmg logic , 
            hitmon.collider.gameObject.GetComponent<enemonHealth>().Damage(damage);

            if (hitmon.collider.gameObject.GetComponent<Rigidbody2D>() != null){
                //it has a rigidbody2D
                hitmon.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(-hitmon.normal * hitForce);
            }
        }
    }

    // mixed code from the YT tutorial + class tutorial
    void drawBullet(){
            if(Input.GetKeyDown(KeyCode.Space)){ // if the player presses the SPACE bar
            GameObject newBeam = Instantiate(beam, transform.position, transform.rotation); // manually create a new beam!
            newBeam.transform.SetParent(gameObject.transform);
            newBeam.transform.localPosition = new Vector3(0, -0.2f);

            // BEAM DIRECTION CODE
            float dir = 0;
            if (playerBehavior.faceRight){ // if the player faces RIGHT,
                dir = 1; // go to that direction
            } else { // else!
                newBeam.GetComponent<SpriteRenderer>().flipX = true; // flip the other way ...
                dir = -1;
            }
            newBeam.GetComponent<Rigidbody2D>().velocity = new Vector3(dir * shootSpeed, newBeam.transform.localPosition.y); // beam body...?
        }
    }
}

