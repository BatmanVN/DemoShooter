using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    [SerializeField] private float lifeTime = 5;
    [SerializeField] private GameObject explosionEffect;
    private void Update()
    {
        Destroy(explosionEffect, lifeTime);
    }
}
