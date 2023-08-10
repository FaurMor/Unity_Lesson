using UnityEngine;
[RequireComponent (typeof(TMPro.TMP_Text))]
public class BricksCountPanel : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _text;
    [SerializeField] private BrickSpawn _brickSpawn;

    private int _maxBricks;
    private int _assembledBricks;

    public bool IsCollected => _assembledBricks == _maxBricks;

    private void OnValidate()
    {
        if (_brickSpawn == null)
        {
            _brickSpawn = FindAnyObjectByType<BrickSpawn>();
        }
    }

    private void Awake()
    {
        _text = GetComponent<TMPro.TMP_Text>();
        _assembledBricks = 0;
    }

    private void Start()
    {
        _maxBricks = _brickSpawn.TotalSpawnedBricks;
        UpdateBricksCount();
    }

    public void AddBrickOnPanel()
    {
        _assembledBricks++;
        UpdateBricksCount();
    }

    private void UpdateBricksCount()
    {
        _text.text = StringFormat(_assembledBricks, _maxBricks);
    }

    private string StringFormat(int bricksCollected, int maxBricks)
        => string.Format("{0}/{1}", bricksCollected, maxBricks);

}
