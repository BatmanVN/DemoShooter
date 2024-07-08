using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMove : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform player;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
