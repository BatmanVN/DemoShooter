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
    [SerializeField] private GunRayCaster raycast;
    [SerializeField] private UnityEvent onShoot;

    private float lastShot;
    private float interval;
    private bool isShooting;

    private void Start() => interval = 60f / rpm;
    //private const int LeftMouseButton = 0;

    private void Update()
    {
        if (isShooting == true)
        {
            UpdateFiring();
        }
    }
    public void StartShooting() => isShooting = true;
    public void StopShooting() => isShooting = false;
    //private void WhenClickShoot()
    //{
    //    if (Input.GetMouseButtonDown(LeftMouseButton))
    //    {
    //        UpdateFiring();
    //    }
    //}

    private void Shoot()
    {
        raycast.PerformRayCasting();
        onShoot.Invoke();
    }
    private void UpdateFiring()
    {
        if (Time.time - lastShot >= interval)
        {
            Shoot();
            lastShot = Time.time;
        }
    }

}

