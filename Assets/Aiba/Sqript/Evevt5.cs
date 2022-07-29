using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evevt5 : MonoBehaviour
{
    float time;
    [SerializeField] float _timeLimit = 10;

    [SerializeField] GameObject _player1;
    [SerializeField] GameObject _player2;

    [SerializeField] int createNumber = 3;
    void Start()
    {
        for (int i = 0; i < createNumber; i++)
        {
            var go1 = Instantiate(_player1);
            var go2 = Instantiate(_player2);

            go1.transform.SetParent(transform);
            go2.transform.SetParent(transform);


        }

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


        if (_timeLimit < time)
        {
            Destroy(gameObject);
        }
    }
}
