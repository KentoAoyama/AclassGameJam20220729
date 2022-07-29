using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _timeText;
    float _timer;
    float _cooltime;
    GameState _status = GameState.NonInitialized;
    [SerializeField] GameObject _player1;
    [SerializeField] GameObject _player2;
    [SerializeField] float _waitTimeUntilGameStarts = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _timeText.text = "時間:" + _timer.ToString("0.00");
        switch(_status)
        {
            case GameState.NonInitialized:
                Debug.Log("Initialise.");
                Instantiate(_player1);
                Instantiate(_player2);
                _status = GameState.Initialized;
                break;
            case GameState.Initialized:
                _cooltime += Time.deltaTime;
                if(_cooltime > _waitTimeUntilGameStarts)
                {
                    Debug.Log("GameStart.");
             
                        
                }
                break;

        }
    }

}
enum GameState
{
    /// <summary>ゲーム初期化前</summary>
    NonInitialized,
    /// <summary>ゲーム初期化済み、ゲーム開始前</summary>
    Initialized,
    /// <summary>ゲーム中</summary>
    InGame,
    /// <summary>プレイヤーがやられた</summary>
    PlayerDead,
}

