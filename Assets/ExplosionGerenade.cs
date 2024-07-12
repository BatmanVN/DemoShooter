using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionGerenade : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrfb;
    [SerializeField] private GameObject bulletRocket;
    [SerializeField] private AudioSource explo;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider bullet)
    {
        if(bullet.CompareTag("Wall"))
        {
            Instantiate(explosionPrfb, transform.position, transform.rotation);
            explo.Play();
            Destroy(bulletRocket);
        }
    }
}
