using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeam : MonoBehaviour
{
    [SerializeField] GameObject _beam;
    PlayerMove _pm;
    GameObject _gameManager;
    GameManager _gm;

    [SerializeField]AudioSource _as;

    bool _shootPlayer;
    
    void OnEnable()
    {
        _beam.SetActive(false);
        _pm = GetComponent<PlayerMove>();

        _gameManager = GameObject.Find("GameManager");
        _gm = _gameManager.GetComponent<GameManager>();
        _as = GetComponent<AudioSource>();
    }

    void Update()
    {
        _shootPlayer = gameObject.tag == "Player1" ? true : false;

        if (_shootPlayer)
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
        _as.Play();
    }

    void OnDisable()
    {
        if (_gm.Stop == false)
        {
            if (_gm)
            {
                if (_shootPlayer)
                {
                    _gm.PlayerDead1();
                }
                else
                {
                    _gm.PlayerDead2();
                }
            }
        }
    }

}
