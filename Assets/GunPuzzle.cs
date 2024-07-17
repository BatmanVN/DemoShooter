using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject muzzleGun;
    [SerializeField] private Transform point;
    //[SerializeField] private float duration;

    public void ShowMuzzle()
    {
        Instantiate(muzzleGun, point.transform.position, point.transform.rotation);
    }
}
