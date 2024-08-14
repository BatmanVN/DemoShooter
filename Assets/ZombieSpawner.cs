using System;
using System.Collections;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int spawnQuality;
    public float spawnInterval;


    private void Start()
    {
        StartCoroutine(SpawnZombieByTime());
    }

    private void SpawnZombie()
    {
        Instantiate(zombiePrefab, transform.position, transform.rotation);
        spawnQuality--;
    }

    private IEnumerator SpawnZombieByTime()
    {
        while(spawnQuality > 0)
        {
            SpawnZombie();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    //private void OnDrawGizmos()
    //{
    //    Color spawnColor = Color.black;
    //    Gizmos.DrawSphere(transform.position, 0.4f);
    //}
}
