using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeam : MonoBehaviour
{
    [SerializeField] GameObject _beam;
    PlayerMove _pm;
    
    void OnEnable()
    {
        _beam.SetActive(false);
        _pm = GetComponent<PlayerMove>();
    }

    void Update()
    {
        bool shootPlayer;

        shootPlayer = gameObject.tag == "Player1" ? true : false;

        if (shootPlayer)
        {
            if (Input.GetButton("Fire1") && _beam.activeSelf == false)
            {
                BeamShoot();
            }
        }
        else
        {
            if (Input.GetButton("Fire2") && _beam.activeSelf == false)
            {
                BeamShoot();
            }
        }

        if (_beam.activeSelf == false)
        {
            _pm.IsBeam = false;
        }
    }

    void BeamShoot()
    {
        _beam.SetActive(true);
        _pm.RotateDirection = !_pm.RotateDirection;
        _pm.IsBeam = true;
    }
}
