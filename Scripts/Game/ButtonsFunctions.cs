using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsFunctions : MonoBehaviour
{
    [SerializeField] private JsonController _jsonController;
    public void Save()
    {
        _jsonController.SaveJson();
    }

    public void Load()
    {
        _jsonController.LoadJson();
    }
}
