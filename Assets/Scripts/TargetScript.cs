using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float speed = 1f;

    private void Update() 
    {
        transform.position += new Vector3(speed,0f,0f) * Time.deltaTime;
    }
}
