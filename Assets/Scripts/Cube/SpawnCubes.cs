using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private float _startTimeMin;
    [SerializeField] private float _startTimeMax;
    [SerializeField] private float _loopTimeMin;
    [SerializeField] private float _loopTimeMax;
    [SerializeField] private Vector3 _spawnZone;
    private float _startTime;
    private float _loopTime;
    // Start is called before the first frame update
    void Start()
    {
        // _startTime = Random.Range(_startTimeMin, _startTimeMax);
        // _loopTime = Random.Range(_loopTimeMin, _loopTimeMax);
        InvokeRepeating("SpawnCube", Random.Range(_startTimeMin, _startTimeMax), Random.Range(_loopTimeMin, _loopTimeMax));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCube()
    {
        if(gameObject.activeSelf)
        {
            GameObject newCube = Instantiate(_cube);
        
            newCube.transform.position = new Vector3(
            Random.Range(transform.position.x - _spawnZone.x / 2, transform.position.x + _spawnZone.x / 2),
            Random.Range(transform.position.y - _spawnZone.y / 2, transform.position.y + _spawnZone.y / 2),
            Random.Range(transform.position.z - _spawnZone.z / 2, transform.position.z + _spawnZone.z / 2)
            );
        }
            
    }
        
    

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, _spawnZone);
    }
}
        
        