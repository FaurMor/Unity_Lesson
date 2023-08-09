using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBarier : MonoBehaviour
{
    [SerializeField] private TimeCountdown _timer;
    [SerializeField] private float _timeDisableObject;
    void Start()
    {
        _timer = FindAnyObjectByType<TimeCountdown>();
    }

    void Update()
    {
        if (_timer != null && _timer.TimeRemaining <= _timeDisableObject)
        {
            Debug.Log("Exit is open!");
            gameObject.SetActive(false);           
        }
    }
}
