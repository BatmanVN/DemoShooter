using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadAmmo : MonoBehaviour
{
    [SerializeField] private int magSize;
    [SerializeField] private int _loadedAmmo;
    [SerializeField] private ShootBullet rockObj;

    public int LoadedAmmo
    {
        get => _loadedAmmo;
        set
        {
            _loadedAmmo = value;
            if (_loadedAmmo <= 0)
            {
                LockShooting();
            }
            else
                UnlockShooting();
        }

    }

    private void UnlockShooting()
    {
        rockObj.enabled = true;
        Reloadbullet();
    }
    private void LockShooting()
    {
        rockObj.enabled = false ;
    }
    private void WhenShoot() => LoadedAmmo--;
    private void Reloadbullet() => _loadedAmmo = magSize;
    private void Update()
    {
        WhenShoot();
    }
    private void Start()
    {
        LoadedAmmo = magSize;
    }
}
