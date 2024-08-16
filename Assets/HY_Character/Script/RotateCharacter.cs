using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCharacter : MonoBehaviour
{
    [SerializeField] private float anglePerSecond;
    [SerializeField] private Transform cameraHold;
    [SerializeField] private float minPitch;
    [SerializeField] private float maxPitch;
    private float pitch;
#if UNITY_EDITOR || UNITY_STANDALONE
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
    private void RotateVertical()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float yaw = mouseX * anglePerSecond;
        transform.Rotate(0, yaw, 0);
    }

    private void RotateHorizontal()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float deltaPitch = - mouseY * anglePerSecond;
        pitch = Mathf.Clamp(pitch + deltaPitch, minPitch, maxPitch);
        cameraHold.localEulerAngles = new Vector3(pitch, 0, 0);
    }
    private void Update()
    {
        RotateVertical();
        RotateHorizontal();
    }
#endif
}
