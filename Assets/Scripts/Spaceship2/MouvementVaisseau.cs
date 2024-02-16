using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class MouvementVaisseau : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rb;
    
    [SerializeField] private float _speed;
    private Vector2 _valeurRecue;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Bouger();
    }

    void Bouger()
    {
        float _x = _valeurRecue.x;
        float _y = _valeurRecue.y;
        _rb.velocity = new Vector3(_x, 0, _y) * _speed;
    }

    public void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
        _valeurRecue = value.Get<Vector2>();
    }
}
