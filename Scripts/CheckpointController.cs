﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public bool checkpointReached;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Player")
        {
            checkpointReached = true;
        } 
    }
}
