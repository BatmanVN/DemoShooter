using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReloadAmmo : MonoBehaviour
{
    [SerializeField] private int magSize;
    [SerializeField] private int _loadedAmmo;
    [SerializeField] private ShootBullet rockObj;
    public UnityEvent<int> loadedChangeAmmo;
    public int LoadedAmmoo
    {
        get => _loadedAmmo;
        set
        {
            _loadedAmmo = value;
            loadedChangeAmmo?.Invoke(LoadedAmmoo);
            if (_loadedAmmo <= 0)
            {
                LockShooting();
                StartCoroutine(Delay());
            }
            else
                UnlockShooting();
        }

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        Reloadbullet();
    }
    private void UnlockShooting()
    {
        rockObj.enabled = true;
    }
    private void LockShooting()
    {
        rockObj.enabled = false;
    }
    public void WhenShoot() => LoadedAmmoo--;
    private void Reloadbullet() => LoadedAmmoo = magSize;
    private void Update()
    {
        
    }
    private void Start()
    {
        Reloadbullet();
    }
}
