using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    float _lookX;
    [SerializeField] float _sensitivity = 5f;

    private void Update()
    {
        _lookX = Input.GetAxis("Mouse X");
        Vector3 rotate = transform.localEulerAngles;
        rotate.y += _lookX * _sensitivity;

        transform.localEulerAngles = rotate;
    }
}
