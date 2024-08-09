//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Enemy_TakeDame : MonoBehaviour
//{
//    [SerializeField] private Health _health;
//    [SerializeField] private float takeDame;
//    public Camera aimingCamera;
//    public LayerMask layerMask;

//    public void PerformRaycasting()
//    {
//        Ray aimingRay = new Ray(aimingCamera.transform.position, aimingCamera.transform.forward);
//        if(Physics.Raycast(aimingRay,out RaycastHit hitInfo),1000f)
//    }

//    private void DeliverDamage(RaycastHit hitInfo)
//    {
//        Health health = hitInfo.collider.GetComponent<Health>();
//            if(health != null)
//        {
//            health.TakeDame(takeDame);
//        }
//    }
//}
