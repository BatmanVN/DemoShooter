using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot_AR : Shooting
{
    [SerializeField] private int rpm;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float speedBullet;
    [SerializeField] private Camera aimingCamera;
    [SerializeField] private UnityEvent onShoot;
    [SerializeField] private LayerMask layerMask;

    private float lastShot;
    private float interval;

    private void Start() => interval = 60f / rpm;
    private const int LeftMouseButton = 0;

    private void Update()
    {
        UpdateFiring();
    }
    private void WhenClickShoot()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) || Input.GetMouseButton(LeftMouseButton))
        {
            AddProjectile();
            Shoot();
        }
    }

    private void AddProjectile()
    {
        GameObject bullet = Instantiate(bulletprefab, bulletPoint.position, bulletPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletPoint.forward * speedBullet;
    }
    private void Shoot()
    {
        PerformRayCasting();
        onShoot.Invoke();
    }
    private void UpdateFiring()
    {
        if (Time.time - lastShot >= interval)
        {
            WhenClickShoot();
            lastShot = Time.time;
        }
    }
    private void PerformRayCasting()
    {
        Ray aimingRay = new Ray(aimingCamera.transform.position, aimingCamera.transform.forward);
        if (Physics.Raycast(aimingRay, out RaycastHit hitInfo, 1000f, layerMask))
        {
            ShowHitEffect(hitInfo);
        }
    }
    private void ShowHitEffect(RaycastHit hitInfo)
    {
        HitSurface hitSurface = hitInfo.collider.GetComponent<HitSurface>();
        if(hitSurface != null)
        {
            GameObject effectPrefab = HitEffectManager.Instance.GetEffectPrefab(hitSurface.surfaceType);
            if(effectPrefab != null)
            {
                Quaternion effectRotation = Quaternion.LookRotation(hitInfo.normal);
                Instantiate(effectPrefab, hitInfo.point, effectRotation);
            }
        }
    }
}