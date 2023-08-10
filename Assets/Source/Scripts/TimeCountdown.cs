using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCountdown : MonoBehaviour
{
    [SerializeField] public float TimeRemaining;
    [SerializeField] private float _totalTime;

    public 

    void Start()
    {
        TimeRemaining = _totalTime;
    }

    void Update()
    {
        if (TimeRemaining > 0)
        {
            TimeRemaining -= Time.deltaTime;
        }
        else
        {
            TimeRemaining = 0;
            enabled = false;
        }
    }
}
