using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPack : MonoBehaviour
{
    [SerializeField] private BricksCountPanel _bricksCountPanel;

    private void OnValidate()
    {
        if ( _bricksCountPanel == null)
        {
            _bricksCountPanel = FindAnyObjectByType<BricksCountPanel>();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.TryGetComponent<Brick>(out var _))
        {
            _bricksCountPanel.AddBrickOnPanel();
            collider.gameObject.SetActive(false);
        }
    }
}
