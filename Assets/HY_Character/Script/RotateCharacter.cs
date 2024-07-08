using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCharacter : MonoBehaviour
{
    public float anglePerSecond;

    private void RotationCharacter()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float yaw = mouseX * anglePerSecond * Time.deltaTime;
        transform.Rotate(0, yaw, 0);
    }
    private void Update()
    {
        RotationCharacter();   
    }
}
