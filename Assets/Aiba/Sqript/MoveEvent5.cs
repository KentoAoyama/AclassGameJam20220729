using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEvent5 : MonoBehaviour
{
    Rigidbody2D _rb;
    void Start()
    {
        _rb=gameObject.GetComponent<Rigidbody2D>();

        var h = Random.Range(-36, 360)*10;
        var v = Random.Range(-36, 360) * 10;

        Vector2 muki = new Vector2(h, v);
        _rb.AddForce(muki.normalized * 10, ForceMode2D.Impulse);
    }

    
    void Update()
    {
        
    }
}
