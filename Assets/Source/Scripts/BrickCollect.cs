using UnityEngine;

public class BrickCollect : MonoBehaviour
{
    [SerializeField] private BricksCountPanel _bricksCountPanel;

    private void OnValidate()
    {
        if ( _bricksCountPanel == null)
        {
            _bricksCountPanel = FindAnyObjectByType<BricksCountPanel>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<UserTarget>(out var player))
        {
            _bricksCountPanel.PickUpBrick();
            gameObject.SetActive(false);
        }
    }
}
