using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Event3 : MonoBehaviour
{
    float time;
    [SerializeField] float _timeLimit = 10;


    float rotare;
    [SerializeField] float rotatoSpeed = 2;
    CinemachineVirtualCamera _camera;

    GameObject a;
    void Start()
    {
        a = GameObject.Find("CM vcam1");

    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;


        if (_timeLimit < time)
        {
            a.transform.rotation = Quaternion.Euler(0, 0, 0);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        a.transform.rotation = Quaternion.Euler(0, 0, rotare += rotatoSpeed);
    }
}
