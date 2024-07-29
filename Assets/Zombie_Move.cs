using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie_Move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent zomNav;
    [SerializeField] private Transform player;
    [SerializeField] private Animator anim;
    [SerializeField] private float distanceStop;
    [SerializeField] private Health_enemy health;

    private void Move()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance > distanceStop)
        {
            zomNav.isStopped = false;
            zomNav.SetDestination(player.position);
            anim.SetBool("Run", true);
        }
        else
        {
                zomNav.isStopped = true;
                anim.SetBool("Run", false);
        }
        if (health.Dead)
        {
            zomNav.isStopped = true;
            anim.SetBool("Run", false);
        }
    }
    private void Update()
    {
        Move();
    }
}
