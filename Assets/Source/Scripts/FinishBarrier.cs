using UnityEngine;

public class FinishBarrier : MonoBehaviour
{
    [SerializeField] private TimeCountdown _timer;
    [SerializeField] private float _timeDisableObject;
    [SerializeField] private BricksCountPanel _panel;

    private void OnValidate()
    {
        if (_panel == null)
        {
            _panel = FindAnyObjectByType<BricksCountPanel>();
        }

        if (_timer == null) 
        {
            _timer = FindAnyObjectByType<TimeCountdown>();
        }
    }

    private void Update()
    {
        if (_timer == null || _timer.TimeRemaining <= _timeDisableObject || _panel.IsCollected)
        {
            gameObject.SetActive(false);           
        }
    }
}
