using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField] private TimerCounter _timerCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        _timerCounter.OnTimeChanged.Subscribe(time =>
        {
            Debug.Log(time);
        });
    }
}
