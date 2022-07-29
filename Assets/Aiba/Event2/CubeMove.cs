using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed=3;

    Rigidbody2D _rb;
    int number;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        number= FindObjectOfType<Event2>().kind;
    }

    private void Update()
    {
        if(number==0)
        {
            MoveV();
        }
        else
        {
            MoveH();
        }

    }

    public void MoveV()
    {
        _rb.velocity = new Vector2(0, _moveSpeed);
    }


    public void MoveH()
    {
            _rb.velocity = new Vector2(_moveSpeed, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Wall"|| collision.gameObject.tag == "Player1"&& collision.gameObject.tag == "Player2")
        {
            _moveSpeed = _moveSpeed * -1;
        }
    }

}
