using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _movePower = 10;
    [SerializeField] float _rotateSpeed = 5;
    [SerializeField] Transform _muzzle;


    float _currentRotate;
    bool _rotateDirection;
    float _rotate;

    public bool RotateDirection { get => _rotateDirection; set => _rotateDirection = value; }

    bool _isBeam = false;
    public bool IsBeam { get => _isBeam; set => _isBeam = value; }

    Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        FirstMove();
        _rotate = _rotateSpeed;
    }


    void Update()
    {
        _rotateSpeed = _rotate;
        
        if (_isBeam)
        {
            BeamMove();
        }
    }

    void FixedUpdate()
    {
        if (!_isBeam)
        {
            Rotate();
        }
    }


    void Rotate()
    {
        float direction;

        direction = _rotateDirection == true ? 1 : -1;

        transform.rotation = Quaternion.Euler(0, 0, _currentRotate += _rotateSpeed * direction);
    }


    void FirstMove()
    {
        var moveX = Vector2.right * _movePower;
        var moveY = Vector2.up * _movePower;

        _rb.velocity = new Vector2(moveX.x, moveY.y);
    }

    void BeamMove()
    {
        var vec = transform.position - _muzzle.position;

        var moveX = vec.x * _movePower;
        var moveY = vec.y * _movePower;

        _rb.velocity = new Vector2(moveX, moveY);
    }


}
