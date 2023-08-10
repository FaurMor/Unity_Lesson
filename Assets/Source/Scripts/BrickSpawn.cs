using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private GameObject _spawnTargetParent;

    private List<Transform> _spawnLocationList;

    public int TotalSpawnedBricks { get; private set; }

    private void Awake()
    {
        _spawnLocationList = _spawnTargetParent.GetComponentsInChildren<Transform>().ToList();
        _spawnLocationList.RemoveAt(0);
        TotalSpawnedBricks = _spawnLocationList.Count;
    }

    private void Start()
    {
        foreach (var spawnTarget in _spawnLocationList)
        {
            Instantiate(_spawnObject, spawnTarget.transform.position, _spawnObject.transform.rotation);
        }
    }
}
