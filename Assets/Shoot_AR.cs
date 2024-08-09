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
    [SerializeField] private UnityEvent onShoot;

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
        AddProjectile();
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
}

