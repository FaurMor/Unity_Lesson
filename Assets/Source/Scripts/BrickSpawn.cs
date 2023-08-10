using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    private const float YCoordinate = 2f;
    [SerializeField] private GameObject _spawnObject;
    private List<Vector3> _spawnLocationList = new List<Vector3>
    {
        new Vector3(10f, YCoordinate, 21.5f),
        new Vector3(19.5f, YCoordinate, 22.8f),
        new Vector3(38.5f, YCoordinate, 18.5f),
        new Vector3(3.75f, YCoordinate, 9.5f),
        new Vector3(25.7f, YCoordinate, 7.7f),
        new Vector3(30f, YCoordinate, 7.7f),
        new Vector3(6.6f, YCoordinate, -5.7f),
        new Vector3(17.3f, YCoordinate, -9.8f),
        new Vector3(37.2f, YCoordinate, -15.8f),
        new Vector3(3.5f, YCoordinate, -17.5f)
    };

    public int TotalSpawnedBricks => _spawnLocationList.Count;

    private void Start()
    {
        foreach(var spawnLocation  in _spawnLocationList)
        {
            Instantiate(_spawnObject, spawnLocation, Quaternion.identity);
        }
    }
}
