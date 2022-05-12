using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputController))]

public class ContolPersonaje : MonoBehaviour
{
    [SerializeField] float _speed = 0f;
    [SerializeField] float _rotationSpeed = 0f;

    InputController _inputController = null;

    void Awake()
    {
        _inputController = GetComponent<InputController>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 input = _inputController.MoveInput();

        transform.position += transform.forward * input.y * _speed * Time.deltaTime;
        transform.position += transform.right * input.x * _speed * Time.deltaTime;
    }
}
