using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private TextMeshProUGUI _coinsCountText;

    private void Start()
    {
        _coinsCountText.text = _gameManager.Coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            _gameManager.Coins++;
            _coinsCountText.text = _gameManager.Coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
