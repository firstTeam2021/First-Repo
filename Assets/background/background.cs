using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    Material newMaterial;
    Vector2 offset;

    public int velocityOnX, velocityOnY;
    // Start is called before the first frame update
    void Start() {

       // offset = new Vector2(velocityOnX, velocityOnY);
        
    }

    // Update is called once per frame
    void Update() {

        offset = new Vector2(velocityOnX, velocityOnY);

        newMaterial =   GetComponent<Renderer>().material;

        newMaterial.mainTextureOffset += offset * Time.deltaTime;
        
    }
}
