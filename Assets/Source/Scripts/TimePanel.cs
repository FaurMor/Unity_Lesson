using UnityEngine;

public class TimePanel : MonoBehaviour
{
    [SerializeField] private TimeCountdown _timer;

    private TMPro.TMP_Text _text;

    void OnValidate()
    {
        if (_timer == null)
        {
            _timer = FindAnyObjectByType<TimeCountdown>();
        }
    }

    private void Awake()
    {
        _text = GetComponent<TMPro.TMP_Text>();
    }

    private void Update()
    {
        if(_timer != null)
        {
            _text.text = TimeFormat(_timer.TimeRemaining);
        }
        else
        {
            enabled = false;
        }
    }
    
    private string TimeFormat(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        return string.Format("{0}:{1:00}", minutes, seconds);
    }
}
