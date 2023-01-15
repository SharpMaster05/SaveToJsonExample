using Assets.Scripts.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class JsonController : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private TextMeshProUGUI _coinsCountText;

    private GameData _gameData = new GameData();
    public void SaveJson()
    {
        _gameData.CoinsCount = _gameManager.Coins;
        File.WriteAllText(Application.streamingAssetsPath + "/GameData.json", JsonUtility.ToJson(_gameData));
    }
    public void LoadJson()
    {
        _gameData = JsonUtility.FromJson<GameData>(File.ReadAllText(Application.streamingAssetsPath + "/GameData.json"));
        _coinsCountText.text = _gameData.CoinsCount.ToString();
    }


}
