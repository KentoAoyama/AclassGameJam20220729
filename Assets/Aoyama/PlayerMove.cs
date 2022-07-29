using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _movePower;
    [SerializeField] float _rotateSpeed;

    float _currentRotate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }


    void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _currentRotate);
    }
}
