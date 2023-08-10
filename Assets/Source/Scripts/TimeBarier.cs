using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBarier : MonoBehaviour
{
    [SerializeField] private TimeCountdown _timer;
    [SerializeField] private float _timeDisableObject;
    [SerializeField] private BricksCountPanel _panel;
    void Start()
    {
        _timer = FindAnyObjectByType<TimeCountdown>();
        _panel = FindAnyObjectByType<BricksCountPanel>();
    }

    void Update()
    {
        if (_timer == null || _timer.TimeRemaining <= _timeDisableObject || _panel.IsCollected())
        {
            Debug.Log("Exit is open!");
            gameObject.SetActive(false);           
        }
    }
}
