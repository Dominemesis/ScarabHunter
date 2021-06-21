using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarabCollectible : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int scoreValue;

    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameLevelManager.AddScore(scoreValue);
            FindObjectOfType<AudioManager>().Play("Scarab");
            Destroy(gameObject);
        }

    }


}
