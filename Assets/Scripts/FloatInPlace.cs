using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatInPlace : MonoBehaviour
{
    private Vector3 _minPosition;
    private Vector3 _maxPosition;

    private bool _moveUpDown;

    private void Start()
    {
        _minPosition = transform.position;
        _maxPosition = transform.position;
        _maxPosition.y += 0.5f;

        _moveUpDown = true;
    }

    private void Update()
    {
        if (transform.position.y <= _minPosition.y)
            _moveUpDown = true;
        else if (transform.position.y >= _maxPosition.y)
            _moveUpDown = false;

        if (_moveUpDown)
            transform.Translate(0, 0.5f * Time.deltaTime, 0, Space.World);
        else
            transform.Translate(0, -0.5f * Time.deltaTime, 0, Space.World);
    }
}
