using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Event1 : MonoBehaviour
{
    [SerializeField] GameObject[] _cubes = new GameObject[3];
    [SerializeField] List<Transform> _pos = new List<Transform>();

    float time;
    [SerializeField] float _timeLimit=10;


    [SerializeField] int _createCount = 10;



    void Start()
    {
        for (int i = 0; i < _createCount; i++)
        {
            var cubetNumber = Random.Range(0, _cubes.Length);  //キューブの選別
            var positionNumber = Random.Range(0, _pos.Count);　//場所の選別

            var cube = Instantiate(_cubes[cubetNumber]);
            cube.transform.SetParent(transform);
            cube.transform.position = _pos[positionNumber].position;

            _pos.RemoveAt(positionNumber);
        }


    }
    private void Update()
    {
        time += Time.deltaTime;

        if(_timeLimit<time)
        {
            Destroy(gameObject);
        }
    }

}
