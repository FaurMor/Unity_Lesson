using UnityEngine;

public class TimeCountdown : MonoBehaviour
{
    [SerializeField] private float _totalTime;

    public float TimeRemaining { get; private set; }

    private void Awake()
    {
        TimeRemaining = _totalTime;
    }

    private void Update()
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
