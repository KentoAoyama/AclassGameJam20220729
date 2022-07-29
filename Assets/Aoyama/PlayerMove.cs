using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _movePower = 10;
    [SerializeField] float _rotateSpeed = 5; 

    float _currentRotate;
    public bool _rotateDirection;
    public bool RotateDirection { get => _rotateDirection; set => _rotateDirection = value; }

    Rigidbody2D _rb;
     
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Rotate();

        Move();
    }


    void Rotate()
    {
        float direction;

        direction =  _rotateDirection == true ? 1 : -1;

        transform.rotation = Quaternion.Euler(0, 0, _currentRotate += _rotateSpeed * direction );
    }

    
    void Move()
    {
        var moveX = Vector2.right * _movePower;
        var moveY = Vector2.up * _movePower;

        _rb.velocity = new Vector2(moveX.x, moveY.y);
    }
}
