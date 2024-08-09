using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayingAmmo : MonoBehaviour
{
    [SerializeField] private Text showAmmo;
    [SerializeField] private GunAmmo bullet;
    public void UpdateAmmo()
    {
        showAmmo.text = bullet.LoadedAmmoo.ToString();
    }
    private void Start()
    {
        bullet.loadedChangeAmmo.AddListener(UpdateAmmo);
        UpdateAmmo();
    }
}
