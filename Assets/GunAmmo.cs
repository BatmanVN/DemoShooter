using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunAmmo : MonoBehaviour
{
    [SerializeField] private int magSize;
    private int _loadedAmmo;
    [SerializeField] private Shooting gun;
    [SerializeField] private DisplayingAmmo display;
    public UnityEvent loadedChangeAmmo;
    public int LoadedAmmoo
    {
        get => _loadedAmmo;
        set
        {
            _loadedAmmo = value;
            loadedChangeAmmo?.Invoke();
            if (_loadedAmmo <= 0)
            {
                LockShooting();
                StartCoroutine(DelayReload());

            }
            else
                UnlockShooting();
        }

    }
    private IEnumerator DelayReload()
    {
        yield return new WaitForSeconds(3);
        Reloadbullet();
    }
    private void UnlockShooting() => gun.IsLockedValue = true;
    private void LockShooting() => gun.IsLockedValue = false;
    public void WhenShoot() => LoadedAmmoo--;
    public void Reloadbullet() => LoadedAmmoo = magSize;

    //public void ReloadWithKey()
    //{
    //     if(Input.GetKeyDown(KeyCode.R) && LoadedAmmoo < 30)
    //    {
    //        StartCoroutine(DelayReload());
    //    }
    //}
    private void Update()
    {
        //ReloadWithKey();
    }
    private void Start()
    {
        Reloadbullet();
    }
}
