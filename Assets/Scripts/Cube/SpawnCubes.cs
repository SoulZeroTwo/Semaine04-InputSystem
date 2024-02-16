using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private float _zoneX;
    [SerializeField] private float _zoneY;
    [SerializeField] private float _zoneZ;
    [SerializeField] private float _startTime;
    [SerializeField] private float _loopTime;
    private Vector3 _spawnZone;
    // Start is called before the first frame update
    void Start()
    {
        _spawnZone = new Vector3(_zoneX, _zoneY, _zoneZ);
        InvokeRepeating("SpawnCube", _startTime, _loopTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCube(){
        GameObject newCube = Instantiate(_cube);
        
        newCube.transform.position = new Vector3(
            Random.Range(transform.position.x - _spawnZone.x / 2, transform.position.x + _spawnZone.x / 2),
            Random.Range(transform.position.y - _spawnZone.y / 2, transform.position.y + _spawnZone.y / 2),
            Random.Range(transform.position.z - _spawnZone.z / 2, transform.position.z + _spawnZone.z / 2)
        );
    }
}
        
        