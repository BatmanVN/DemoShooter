using System;
using System.Collections;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int spawnQuality;
    public float spawnInterval;
    private bool isRunning;

    //private void Start()
    //{
    //    StartCoroutine(SpawnZombieByTime());
    //}

    private void SpawnZombie()
    {
        Instantiate(zombiePrefab, transform.position, transform.rotation);
        spawnQuality--;
    }

    private void OnTriggerEnter(Collider spawnZom)
    {
        if (!isRunning && spawnZom.CompareTag("Player"))
        {
            isRunning = true;
            StartCoroutine(SpawnZombieByTime());
        }
    }

    private void OnTriggerExit(Collider spawnZom)
    {
        if (isRunning && spawnZom.CompareTag("Player"))
        {
            isRunning = false;
            StopAllCoroutines();
        }
    }
    private IEnumerator SpawnZombieByTime()
    {
        while (spawnQuality > 0)
        {
            SpawnZombie();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
