using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootLauncher : Shooting
{
    private const int LeftMouseButton = 0;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float speedBullet;
    [SerializeField] private AudioSource shootingSound;
    public UnityEvent onShoot;

    private void Start()
    {
    }
    //private void Update()
    //{
    //    WhenShoot();
    //}
    public void Shoot()
    {
        //if (Input.GetMouseButtonDown(LeftMouseButton))
        //{
        if(!IsLockedValue)
            Shootbullet();
            AddProjectile();
            onShoot?.Invoke();
        //}
    }

    private void Shootbullet() => shootingSound.Play();
    private void AddProjectile()
    {
        GameObject bullet = Instantiate(bulletprefab, bulletPoint.position, bulletPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletPoint.forward * speedBullet;
    }
}
