using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksCountPanel : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _text;
    [SerializeField] private BrickSpawn _brickSpawn;
    private int _maxBricks;
    [SerializeField] private int _assembledBricks = 0;
    void Start()
    {
        TryGetComponent<TMPro.TMP_Text>(out _text);
        _brickSpawn = FindAnyObjectByType<BrickSpawn>();
        _maxBricks = _brickSpawn.TotalSpawnedBricks;
        _assembledBricks = 0;
        ShowBricksCollected();
    }

    public bool IsCollected()
        => _assembledBricks == _maxBricks;
    public void AccureBrick()
    {
        _assembledBricks++;
        ShowBricksCollected();
    }

    private void ShowBricksCollected()
    {
        _text.text = StringFormat(_assembledBricks, _maxBricks);
    }

    private string StringFormat(int bricksCollected, int maxBricks)
        => string.Format("{0}/{1}", bricksCollected, maxBricks);

}
