﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }
}
