using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event1 : MonoBehaviour
{
    [SerializeField] GameObject[] _cubes = new GameObject[3];
    [SerializeField] Transform[] _pos = new Transform[10];

    int _createCount = 10;

    void Start()
    {
        for (int i = 0; i <= _createCount; i++)
        {
            var cubetNumber = Random.Range(0, _cubes.Length);  //�L���[�u�̑I��
            var positionNumber = Random.Range(0, _pos.Length);�@//�ꏊ�̑I��

            var cube = Instantiate(_cubes[cubetNumber]);
            cube.transform.position = _pos[positionNumber].position;
        }


    }

}
