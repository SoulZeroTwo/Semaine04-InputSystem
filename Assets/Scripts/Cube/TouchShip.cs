using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShip : MonoBehaviour
{
    [SerializeField] private GameObject _floor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.gameObject.tag == "Danger")
        {
            gameObject.SetActive(false);
        }
        
    }
}
