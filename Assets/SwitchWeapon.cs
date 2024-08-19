using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public GameObject[] guns;
    public GameObject[] ammoBar;
    public GameObject[] shootButton;
    private int currentIndex;

    public void SwitchGun()
    {
        currentIndex = (currentIndex + 1) % guns.Length;
        SetActiveGun(currentIndex);
    }

    private void SetActiveGun(int gunIndex)
    {
        for(int i = 0; i < guns.Length; i++)
        {
            bool isActive = (i == gunIndex);
            guns[i].SetActive(isActive);
            ammoBar[i].SetActive(isActive);
            shootButton[i].SetActive(isActive);
            if(isActive)
            {
                guns[i].SendMessage("OnGunSelected", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
