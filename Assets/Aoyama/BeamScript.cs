using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamScript : MonoBehaviour
{
    Collider2D _collider;


    void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Wall" && collision.gameObject.tag != "Beam")
        {
            Destroy(collision.gameObject, 0.1f);
        }
    }

    public void ShootBeam()
    {
        _collider.enabled = true;
    }

    public void ColliderFinish()
    {
        _collider.enabled = false;
    }

    public void BeamFinish()
    {
        gameObject.SetActive(false);
    }

}
