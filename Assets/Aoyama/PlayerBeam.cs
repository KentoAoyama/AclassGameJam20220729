using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeam : MonoBehaviour
{
    [SerializeField] GameObject _beam;
    [SerializeField] float _shootInterval = 0.2f;
    [SerializeField] float _beamInterval = 0.2f;
    float _timer;

    Collider2D _collider;
    
    void OnEnable()
    {
        _beam.SetActive(false);
        _collider = _beam.GetComponent<Collider2D>();
    }

    void Update()
    {
        bool shootPlayer;

        _timer += Time.deltaTime;

        shootPlayer = gameObject.tag == "Player1" ? true : false;

        if (shootPlayer)
        {
            if (Input.GetButton("Fire1") && _timer > _shootInterval)
            {
                StartCoroutine(BeamShoot());
            }
        }
        else
        {
            if (Input.GetButton("Fire2") && _timer > _shootInterval)
            {
                StartCoroutine(BeamShoot());
            }
        }
    }

    IEnumerator BeamShoot()
    {
        _beam.SetActive(true);
        yield return new WaitForSeconds(_beamInterval);
        _beam.SetActive(false);
    }


    public void ShootBeam()
    {
        _collider.enabled = true;
    }

    public void BeamFinish()
    {
        _collider.enabled = false;
    }
}
