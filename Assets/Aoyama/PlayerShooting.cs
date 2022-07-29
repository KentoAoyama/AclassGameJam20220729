using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class PlayerShooting : MonoBehaviour
//{
//    [SerializeField] GameObject _bullet;
//    [SerializeField] Transform _muzzle;
//    //[SerializeField] float _shootInterval = 0.2f;
//    //float _timer;
    

//    void Update()
//    {
//        bool shootPlayer;
        
//        _timer += Time.deltaTime;

//        shootPlayer = gameObject.tag == "Player1" ? true : false;

//        if (shootPlayer)
//        {
//            if (Input.GetButton("Fire1") && _timer > _shootInterval)
//            {
//                Shoot();
//            }
//        }
//        else
//        {
//            if (Input.GetButton("Fire2") && _timer > _shootInterval)
//            {
//                Shoot();
//            }
//        }
//    }

//        void Shoot()
//        {
//            _timer = 0;
//            Instantiate(_bullet, _muzzle.position, this.transform.rotation);
//        }
//    }
