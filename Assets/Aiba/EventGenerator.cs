using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGenerator : MonoBehaviour
{


    [SerializeField] GameObject[] _events = new GameObject[3];

    [SerializeField] float _timeLimit = 10;
    float _countTime = 0;

    bool _isWorking;


    void Start()
    {

    }


    void Update()
    {
        //ゲームステートが終わりだったら止める。
        //if()
        //{


        //}

        //イベント中だったら何もしない。
        if (!_isWorking)
        {
            return;
        }

        //イベントが既にあったら何もしない
        if(transform.childCount==0)
        {
            _countTime += Time.deltaTime;
        }
        else
        {
            return;
        }


        
        //イベントの生成間隔
        if (_countTime > _timeLimit)
        {
            _isWorking = true;
            _countTime = 0;

            var r = Random.Range(0, 3);
            var go = Instantiate(_events[r]);
            go.transform.SetParent(this.transform);
        }




    }

    /// <summary>イベントの生成を止める</summary>
    public void StopGeneration()
    {
        _isWorking = false;
    }

    /// <summary>イベントの生成を始める</summary>
    public void StartGeneration()
    {
        _isWorking = true;
        _countTime = 0;
    }
}
