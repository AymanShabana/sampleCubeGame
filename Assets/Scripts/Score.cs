﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = ""+((int)player.position.z);
    }
}
