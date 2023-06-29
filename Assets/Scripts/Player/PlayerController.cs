using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 3.5f;
    private CharacterController _characterController;
    private float 
        _horizontalInput, 
        _verticalInput, 
        _gravity=9.81f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        PlayerMove();
        CursorSetup();
    }

    private static void CursorSetup()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.visible == true)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
            
        }
    }

    private void PlayerMove()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        Vector3 _direction = new Vector3(_horizontalInput, 0f, _verticalInput);
        Vector3 velocity = _direction * _movementSpeed;
        velocity.y -= _gravity;

        velocity = transform.transform.TransformDirection(velocity);

        _characterController.Move(velocity * Time.deltaTime);
    }
}
