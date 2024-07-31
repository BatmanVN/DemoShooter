using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private CharacterController playerController;
    [SerializeField] private float movingSpeed;

    private void OnValidate() => playerController = GetComponent<CharacterController>();

    private void MovePlayer()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 direction  = transform.right * hInput * 2 + transform.forward * vInput;
        direction.y = 0;
        playerController.SimpleMove(direction * movingSpeed);
    }
    void Update()
    {
        MovePlayer();
    }
}
