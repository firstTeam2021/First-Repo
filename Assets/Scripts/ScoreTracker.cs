using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTracker : MonoBehaviour
{
public Text ScoreText;
public Text HighScore;

public float ScoreCounter;
public float HighScoreCounter;

public float pointsPerSec; 

public bool ScoreIncrease;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("HighScore") != null){

            HighScoreCounter = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update(){

        if(ScoreIncrease){

             ScoreCounter += pointsPerSec * Time.deltaTime;
        }

        if(ScoreCounter > HighScoreCounter){

            HighScoreCounter = ScoreCounter;
            PlayerPrefs.SetFloat("Highscore", HighScoreCounter);
        }

        ScoreText.text = "Score: " + Mathf.Round(ScoreCounter);
        HighScore.text = "HighScore " + Mathf.Round(HighScoreCounter);

    }

    public void AddingScore(int addinPoints){

        ScoreCounter += addinPoints;

    }
}
