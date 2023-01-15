using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _coins;
    public int Coins
    {
        get => _coins;
        set => _coins = value;
    }
}
