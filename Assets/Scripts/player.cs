using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour{

    public float playerSpeed;
    public float jumpForce; 

    public float jumpingTime;
    private float jumpingTimeCounter;
    
    private  Rigidbody2D newRigidBody; // creating a new rigid body

    public bool grounded;
    public LayerMask isGounded;

    private Collider2D newCollider;

    private Animator newAnimator;

    public gameManager myGameManager;



    // Start is called before the first frame update
    void Start(){
       newRigidBody = GetComponent<Rigidbody2D>();
       newCollider = GetComponent<Collider2D>();
       newAnimator = GetComponent<Animator>();

       jumpingTimeCounter = jumpingTime;
    }

    // Update is called once per frame
    void Update(){

        grounded = Physics2D.IsTouchingLayers(newCollider, isGounded);

        newRigidBody.velocity = new Vector2(playerSpeed, newRigidBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){

            if(grounded){

             newRigidBody.velocity = new Vector2(newRigidBody.velocity.x, jumpForce);

            }

        }

        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)){

            if(jumpingTimeCounter > 0){

                  newRigidBody.velocity = new Vector2(newRigidBody.velocity.x, jumpForce);
                  jumpingTimeCounter-= Time.deltaTime;
            }
        }

      /*  if(Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0)){

            jumpingTimeCounter = 0;
        }*/

        if(grounded){

            jumpingTimeCounter = jumpingTime;
        }

        newAnimator.SetFloat ("Speed", newRigidBody.velocity.x);
        newAnimator.SetBool ("onGround", grounded);
    }

    void OnCollisionEnter2D (Collision2D other){
         
         if(other.gameObject.tag == "Killbox"){

             myGameManager.restartGame();


         }
    }
}