using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoins : MonoBehaviour
{

    public int attributeScore;

    private ScoreTracker myScoreTracker;
    // Start is called before the first frame update
    void Start()
    {
        myScoreTracker = FindObjectOfType<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D newObject){

        if(newObject.gameObject.name == "Player"){

            myScoreTracker.AddingScore(attributeScore);
            gameObject.SetActive(false);
        }
    }
}
