using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventGenerator : MonoBehaviour
{


    [SerializeField] GameObject[] _events = new GameObject[3];

    [SerializeField] float _timeLimit = 5;
    float _countTime = 0;

    bool _isWorking=true;

    [SerializeField] GameObject _text;

    [SerializeField] GameObject _defultWall;

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
            _defultWall.SetActive(true);
        }
        else
        {
            return;
        }


        if (_countTime > 3)
        {
            _text.SetActive(true);
        }


        //イベントの生成間隔
        if (_countTime > _timeLimit)
        {
            _text.SetActive(false);
            _defultWall.SetActive(false);
            _countTime = 0;

            var r = Random.Range(0, _events.Length);
            var go = Instantiate(_events[r]);
            go.transform.SetParent(this.transform);
        }




    }

    /// <summary>イベントの生成を止める</summary>
    public void StopGeneration()
    {
        _isWorking = false;
        _text.SetActive(false);
    }

    /// <summary>イベントの生成を始める</summary>
    public void StartGeneration()
    {
        _isWorking = true;
        _countTime = 0;
        _text.SetActive(false);
        _defultWall.SetActive(true);
    }
}
