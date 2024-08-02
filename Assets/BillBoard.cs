using System;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        LookTowardCamera();
    }
    private void Update() => LookTowardCamera();
    private void LookTowardCamera()
    {
        transform.LookAt(mainCamera.transform);
    }
}
