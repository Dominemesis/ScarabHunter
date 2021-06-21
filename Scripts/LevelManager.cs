using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
  {
    public CharacterController2D gamePlayer;
    public float respawnDelay;
    public int score = 0;
    public Text scoreText;
    bool gameHasEnded = false;
    bool gameWasWon = false;
    public float GameOverDelay = 1f;
    public float GameWonDelay = 1f;

     

    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<CharacterController2D> ();
        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int valueOfScore)
    {
        score += valueOfScore;
        scoreText.text = "" + score;

    }
    public void Respawn()
    {
        StartCoroutine("DelayCoroutine");
    }

    public IEnumerator DelayCoroutine()
    {
        //gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        //gamePlayer.gameObject.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("GameOverScreen", GameOverDelay);
        }

    }
        void GameOverScreen()
        {
            SceneManager.LoadScene(2);
        }

    public void WinGame()
    {
        if (gameWasWon == false)
        {
            gameWasWon = true;
            Debug.Log("You WON!");
            Invoke("VictoryScreen", GameWonDelay);

        }
    }

    public void VictoryScreen()
    {
        SceneManager.LoadScene(3);
    }
}

