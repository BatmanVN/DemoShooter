using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_TakeDame : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Animator zomAnim;
    [SerializeField] private float takeDame;
    [SerializeField] private Zombie_Move move;

    private void OnTriggerEnter(Collider enemy)
    {
            if (enemy.CompareTag("AR_bullet"))
            {
                _health.TakeDame(takeDame);
            }
            if (_health.Dead)
            {
                zomAnim.SetTrigger("dead");
                move.enabled = false;
            }
    }
    private void Start()
    {

    }
}
