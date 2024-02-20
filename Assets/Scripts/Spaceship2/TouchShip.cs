using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShip : MonoBehaviour
{
    [SerializeField] private GameObject _spawnZone;
    public int _points;
    public bool _gameOver;
    // Start is called before the first frame update
    void Start()
    {
        _gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.tag);

        // Si c'est un danger, le vaisseau est détruit. Game Over = true. On log les points.
        if(other.gameObject.tag == "Danger")
        {
            Debug.Log("Game Over! Points: " + _points);
            _spawnZone.SetActive(false);
            gameObject.SetActive(false);
        }

        // Sinon, si c'est un donneur de point:
            // on ajoute un point,
            // on log les points
            // et on désactive le doneur de point.
        else if(other.gameObject.tag == "Point")
        {
            _points++;
            Debug.Log("Points: " + _points);
            Destroy(other.gameObject);
        }
        
    }
}
