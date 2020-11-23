using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerCounter : MonoBehaviour
{
    private Subject<int> _timerSubject = new Subject<int>();

    public IObservable<int> OnTimeChanged
    {
        get
        {
            return _timerSubject;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CoroutineTimer()
    {
        int time = 100;
        while (time > 0)
        {
            time--;
            _timerSubject.OnNext(time);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
