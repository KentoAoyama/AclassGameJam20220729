using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounter : MonoBehaviour
{
    [SerializeField] Sprite _playerUiSprite1P;
    [SerializeField] Sprite _playerUiSprite2P;
    [SerializeField] Vector2 _spriteSize1P = new Vector2(50f, 50f);
    [SerializeField] Vector2 _spriteSize2P = new Vector2(50f, 50f);
    [SerializeField] RectTransform _playerCounterPanel1P;
    [SerializeField] RectTransform _playerCounterPanel2P;
    // Start is called before the first frame update
    public void Refresh1(int playerCount)
    {
        if(_playerUiSprite1P && _playerCounterPanel1P)
        {
            foreach(Transform t in _playerCounterPanel1P.transform)
            {
                Destroy(t.gameObject);
            }

            for(int i = 0; i < playerCount - 1; i++)
            {
                GameObject go = new GameObject();
                Image image = go.AddComponent<Image>();
                image.sprite = _playerUiSprite1P;
                RectTransform rect = go.GetComponent<RectTransform>();
                rect.sizeDelta = _spriteSize1P;
                go.transform.SetParent(_playerCounterPanel1P.transform);
            }
        }
    }
    public void Refresh2(int playerCount)
    {
        if (_playerUiSprite2P && _playerCounterPanel2P)
        {
            foreach (Transform t in _playerCounterPanel2P.transform)
            {
                Destroy(t.gameObject);
            }

            for (int i = 0; i < playerCount - 1; i++)
            {
                GameObject go = new GameObject();
                Image image = go.AddComponent<Image>();
                image.sprite = _playerUiSprite2P;
                RectTransform rect = go.GetComponent<RectTransform>();
                rect.sizeDelta = _spriteSize2P;
                go.transform.SetParent(_playerCounterPanel2P.transform);
            }
        }

    }
}
