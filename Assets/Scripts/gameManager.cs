using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public Transform platformGenerator;
    private Vector3 startingPoint;

    public player myPlayer;
    private Vector3 playerStartingPoint;

    private  PlatformDestroy[] platformList;

    private ScoreTracker myScoreTracker;

    public DeathMenu Menu;

    // Start is called before the first frame update
    void Start()
    {
        startingPoint = platformGenerator.position;
        playerStartingPoint = myPlayer.transform.position;

        myScoreTracker = FindObjectOfType<ScoreTracker>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame(){

        myScoreTracker.ScoreIncrease = false;
       myPlayer.gameObject.SetActive(false);

       Menu.gameObject.SetActive(true);

       // StartCoroutine ("restartGameCo");

    }

    public void restart(){


         Menu.gameObject.SetActive(false);
         platformList = FindObjectsOfType<PlatformDestroy>();

       for(int i=0; i<platformList.Length; i++){

           platformList[i].gameObject.SetActive(false);

       }

       myPlayer.transform.position = playerStartingPoint;
       platformGenerator.position = startingPoint;
       myPlayer.gameObject.SetActive(true);

       myScoreTracker.ScoreCounter = 0;
       myScoreTracker.ScoreIncrease = true;
    }

   /* public IEnumerator restartGameCo(){

       myScoreTracker.ScoreIncrease = false;
       myPlayer.gameObject.SetActive(false);
       yield return new WaitForSeconds(0.5f);
       platformList = FindObjectsOfType<PlatformDestroy>();

       for(int i=0; i<platformList.Length; i++){

           platformList[i].gameObject.SetActive(false);

       }

       myPlayer.transform.position = playerStartingPoint;
       platformGenerator.position = startingPoint;
       myPlayer.gameObject.SetActive(true);

       myScoreTracker.ScoreCounter = 0;
       myScoreTracker.ScoreIncrease = true;
    }*/
}
