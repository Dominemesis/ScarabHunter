﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryScreen : MonoBehaviour
{
    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}