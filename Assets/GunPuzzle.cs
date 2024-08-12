using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject muzzleGun;
    [SerializeField] private Transform point;

    public void ShowMuzzle()
    {
        Instantiate(muzzleGun, point.transform.position, point.transform.rotation);
    }
}
