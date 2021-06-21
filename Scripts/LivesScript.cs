using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesScript : MonoBehaviour
{
    public int startingLives;
    private int lifeCounter;
    public LevelManager lm;

    private Text lifeText;
    void Start()
    {
        lifeText = GetComponent<Text>();
        lifeCounter = startingLives;
        lm = GameObject.FindObjectOfType(typeof(LevelManager)) as LevelManager;
    }

    
    void Update()
    {
        lifeText.text = "X " + lifeCounter;
    }
     
    public void GiveLife()
    {
        lifeCounter+=1;
    }

    public void TakeLife()
    {
        lifeCounter-=1;
        if (lifeCounter < 0)
        {
            lm.EndGame();
        }

    }

    
}
