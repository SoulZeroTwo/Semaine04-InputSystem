using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveSpaceship : MonoBehaviour
{
    private float _x;
    private float _y;
    private Vector3 _movement;
    private Rigidbody _rb;
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void ReceiveInput(InputAction.CallbackContext context)
    {
        // Debug.Log(context.ReadValue<Vector2>());
        _x = context.ReadValue<Vector2>().x;
        _y = context.ReadValue<Vector2>().y;
        _movement = new Vector3 (_x, _y, 0);
    }

    void Move()
    {
        _rb.AddForce(_movement * _speed, ForceMode.Force);
    }
}
