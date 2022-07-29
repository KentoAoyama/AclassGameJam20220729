using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] Text _timeText;
    float _timer = 10;
    GameState _status = GameState.NonInitialized;
    [SerializeField] GameObject _player1;
    [SerializeField] GameObject _player2;
    [SerializeField] float _waitTimePlayerDeath = 2f;
    [SerializeField] Text _Win1Text;
    [SerializeField] Text _Win2Text;
    [SerializeField] Text _lifetext1;
    [SerializeField] Text _lifetext2;
    [SerializeField] Text _DrowText;
    int _life1 = 3;
    int _life2 = 3;
    public bool Stop = false;
    // Start is called before the first frame update
    void Start()
    {
        _Win1Text.enabled = false;
        _Win2Text.enabled = false;
        _DrowText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        _timeText.text = "時間:" + _timer.ToString("0.00");
        switch(_status)
        {
            case GameState.NonInitialized:
                Debug.Log("Initialise.");
                Instantiate(_player1);
                Instantiate(_player2);
                _lifetext1.text = "P1残機" + _life1;
                _lifetext2.text = "P2残機" + _life2;
                _status = GameState.Initialized;
                break;
            case GameState.Initialized:
                Debug.Log("GameStart.");
                _status = GameState.InGame;
                break;

        }
        if(_life1 == 0 && _life2 == 0)
        {
            _Win1Text.enabled = false;
            _Win2Text.enabled = false;
            _DrowText.enabled = true;
        }
        if(_timer < 0)
        {
            _timeText.text = "時間: 0.00";
            Stop = true; 
            if(_life1 == _life2)
            {
                _DrowText.enabled = true;
            }
            else if(_life1 > _life2)
            {
                _Win1Text.enabled = true;
            }
            else
            {
                _Win2Text.enabled = true;
            }
        }
    }
    public void PlayerDead1()
    {
        Debug.Log("Player Dead1."); 
        _life1 -= 1;    // 残機を減らす
        _lifetext1.text = "P1残機" + _life1;
        if (_Win2Text && _life1 < 1)
        {
            _Win2Text.enabled = true;
        }
        StartCoroutine("InstansTimeP1");
    }
    public void PlayerDead2()
    {
        Debug.Log("Player Dead2.");
        _life2 -= 1;    // 残機を減らす
        _lifetext2.text = "P2残機" + _life2;

        if (_Win1Text && _life2 < 1)
        {
            _Win1Text.enabled = true;
        }
        StartCoroutine("InstansTimeP2");
    }

    void GameOver()
    {
        Debug.Log("Gameover");
    }
    
    IEnumerator InstansTimeP1()
    {
        yield return new WaitForSeconds(2f);
        if (_life1 > 0)
        {
            Instantiate(_player1);
            _status = GameState.Initialized;
        }
        else
        {
            GameOver();
        }
    }
    
    IEnumerator InstansTimeP2()
    {
        yield return new WaitForSeconds(2f);
        if (_life2 > 0)
        {
            Instantiate(_player2);
            _status = GameState.Initialized;
        }
        else
        {
            GameOver();
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
}

