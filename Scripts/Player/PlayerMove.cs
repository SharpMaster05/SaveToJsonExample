using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float _speed = 5f;
    private float _directionX;

    void Update()
    {
        _directionX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_speed * _directionX * Time.deltaTime, 0, 0);
    }
}
