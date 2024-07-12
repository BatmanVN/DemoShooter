using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    private const int LeftMouseButton = 0;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float speedBullet;
    [SerializeField] private AudioSource shootingSound;
    //[SerializeField] private Rigidbody bullet;
    //[SerializeField] private Animator anim;

    private void Start()
    {
    }
    private void Update()
    {
        WhenShoot();
    }
    private void WhenShoot()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            Shootbullet();
            AddProjectile();
        }
    }

    private void Shootbullet() => shootingSound.Play();
    private void AddProjectile()
    {
        GameObject bullet = Instantiate(bulletprefab, bulletPoint.position, bulletPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletPoint.forward * speedBullet;
    }
}
