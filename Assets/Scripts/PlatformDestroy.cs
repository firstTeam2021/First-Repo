using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{
    public GameObject platformDestroyer;
    // Start is called before the first frame update
    void Start()
    {
        platformDestroyer = GameObject.Find("platformDestroyer");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < platformDestroyer.transform.position.x){
            
           // Destroy(gameObject);
            gameObject.SetActive(false);
        }
        
    }
}
