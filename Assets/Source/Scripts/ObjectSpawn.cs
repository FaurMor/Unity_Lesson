using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    private const float YCoordinate = 0f;

    [SerializeField] private GameObject spawnObject;
    private List<Vector3> _spawnLocationList = new List<Vector3>
    {
        new Vector3(58.5f, YCoordinate, 25f),
        new Vector3(68.5f, YCoordinate, 26.5f),
        new Vector3(87.5f, YCoordinate, 22f),
        new Vector3(52.5f, YCoordinate, 13f),
        new Vector3(74.5f, YCoordinate, 11f),
        new Vector3(79f, YCoordinate, 11f),
        new Vector3(55.5f, YCoordinate, -2.5f),
        new Vector3(66f, YCoordinate, -6f),
        new Vector3(52.5f, YCoordinate, -14f),
        new Vector3(86f, YCoordinate, -12f)
    };

    private void Start()
    {
        foreach(var spawnLocation  in _spawnLocationList)
        {
            Instantiate(spawnObject, spawnLocation, Quaternion.identity, transform);
        }
    }
}
