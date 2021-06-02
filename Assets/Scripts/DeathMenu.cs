using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public string MainMenu;

    public void GameRestart(){

        FindObjectOfType<gameManager>().restart();

    }

    public void ReturnToMain(){

        Application.LoadLevel(MainMenu);

    }
}
