using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollect : MonoBehaviour
{
    [SerializeField] private BricksCountPanel _bricksCountPanel;

    private void Start()
    {
        _bricksCountPanel = FindAnyObjectByType<BricksCountPanel>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<User>(out var player))
        {
            _bricksCountPanel.AccureBrick();
            Debug.Log("Brick is collected");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Is not player");
        }
    }
}
