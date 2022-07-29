using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event4 : MonoBehaviour
{
    GameObject _nomalCamera;
    GameObject _shakeCamera;

    float time;
    [SerializeField] float _timeLimit = 10;

    void Start()
    {
        _nomalCamera = GameObject.Find("CM vcam1");
        _shakeCamera = GameObject.Find("C2");

        _nomalCamera.SetActive(false);
        _shakeCamera.SetActive(true);
    }

    // Update is called once per frame
  
        void Update()
        {

            time += Time.deltaTime;


            if (_timeLimit < time)
            {
            _nomalCamera.SetActive(true);
            _shakeCamera.SetActive(false);

            Destroy(gameObject);
            }
        }
    
}
