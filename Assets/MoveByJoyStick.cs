using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByJoyStick : MonoBehaviour
{
    public CharacterController characterController;
    public float movingSpeed;
    public Joystick joystick;

    private void OnValidate() => characterController = GetComponent<CharacterController>();

    private void Update()
    {
        float hInput = joystick.Horizontal;
        float xInput = joystick.Vertical;
        Vector3 direction = transform.right * hInput + transform.forward * xInput;
        characterController.SimpleMove(direction * movingSpeed);
    }
}
