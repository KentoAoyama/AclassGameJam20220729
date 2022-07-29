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
        _timeText.text = "����:" + _timer.ToString("0.00");
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
    /// <summary>�Q�[���������O</summary>
    NonInitialized,
    /// <summary>�Q�[���������ς݁A�Q�[���J�n�O</summary>
    Initialized,
    /// <summary>�Q�[����</summary>
    InGame,
    /// <summary>�v���C���[�����ꂽ</summary>
    PlayerDead,
}

