using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _bulletSpeed = 10;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.velocity = transform.right * _bulletSpeed;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
            Destroy(gameObject);
    }
}
