using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int scoreValue;
    
    

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameLevelManager.AddScore(scoreValue);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("FinalScarab");
            gameLevelManager.WinGame();
            //gameLevelManager.VictoryScreen();
        }
   
           
    }
    

}
