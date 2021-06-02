using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public player myPlayer;

    private Vector3 lastPlayerPosition;

    private float movingDistance;


    // Start is called before the first frame update
    void Start(){
        
        myPlayer = FindObjectOfType<player>();
    }

    // Update is called once per frame
    void Update(){

        movingDistance = myPlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
        


        lastPlayerPosition = myPlayer.transform.position; 
    }
}

