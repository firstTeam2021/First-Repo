using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    public float gravity;
    public Vector2 velocity;
    public float jumpVelocity = 30;
    public float groundHeight = 10;
    public bool onGround = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onGround){
            
            if(Input.GetKeyDown(KeyCode.Space)){

                onGround =false;
                velocity.y = jumpVelocity;
            }
        }
    }

    private void fixedUpdate(){

        Vector2 pos = transform.position;

        if(!onGround){
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;

            if(pos.y <= groundHeight){

                pos.y = groundHeight;
                onGround = true;

            }
        }

        transform.position = pos;

    }
}