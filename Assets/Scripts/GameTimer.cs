﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameTimer : MonoBehaviour
{
    [Tooltip("Level timer in SECONDS")]
    [SerializeField] float levelTime = 10f;
    bool triggeredLevelFinished = false;


    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime; //tempo total divido pelo atual "posição do slider"

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
