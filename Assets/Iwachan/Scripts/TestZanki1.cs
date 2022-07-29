using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestZanki1 : MonoBehaviour
{
    GameManager gm;
    GameObject gmobject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonDown("Fire3"))
            {
                GameObject gmobject = GameObject.Find("GameManager");
                GameManager gm = gmobject.GetComponent<GameManager>();
            if (gm.Stop == false)
            {
                if (gm)
                {
                    gm.PlayerDead1();
                }
                Destroy(this.gameObject);
            }
            }
    }
}
