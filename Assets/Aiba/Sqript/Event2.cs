using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Event2 : MonoBehaviour
{
    [SerializeField] GameObject _cubesVertical;
    [SerializeField] Transform[] _posVertical = new Transform[3];

    [SerializeField] GameObject _cubesHorizontal;
    [SerializeField] Transform[] _posHorizontal = new Transform[3];

    CubeMove cubeMove;

    float time;
    [SerializeField] float _timeLimit = 10;


    public int kind;

    void Start()
    {
        cubeMove = FindObjectOfType<CubeMove>();
        kind = Random.Range(0, 2);




        //0ÇæÇ¡ÇΩÇÁècÅAÇPÇæÇ¡ÇΩÇÁâ°
        if (kind == 0)
        {
            for (int i = 0; i < _posVertical.Length; i++)
            {
                var cube = Instantiate(_cubesVertical);
                cube.transform.position = _posVertical[i].position;
                cube.transform.SetParent(transform);
            }
        }
        else
        {
            for (int i = 0; i < _posHorizontal.Length; i++)
            {
                var cube = Instantiate(_cubesHorizontal);
                cube.transform.position = _posHorizontal[i].position;
                cube.transform.SetParent(transform);
            }
        }
    }

    private void Update()
    {
        time += Time.deltaTime;


        if (_timeLimit < time)
        {
            Destroy(gameObject);
        }
    }

    //void Update()
    //{
    //    //íBïΩçÏ
    //    if (kind == 0)
    //    {
    //        Debug.Log("AAA");
    //        cubeMove.MoveV();




    //        //  cubeMove.ToList().ForEach(c => c.MoveV());
    //    }
    //    else
    //    {
    //        Debug.Log("BBB");
    //        cubeMove.MoveH();



    //        // cubeMove.ToList().ForEach(c => c.MoveH());
    //    }

    //}

}
