using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    float _mouseY;
    [SerializeField] private float _sensitivity = 5f;

    private void Update()
    {
        _mouseY = Input.GetAxis("Mouse Y");
        Vector3 _lookY = transform.localEulerAngles;
        _lookY.x -= _mouseY * _sensitivity;
        transform.localEulerAngles = _lookY;
    }
}
