using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Zombie_Move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent zomNav;
    [SerializeField] private Transform player;
    [SerializeField] private Animator anim;
    [SerializeField] private float distanceStop;
    [SerializeField] private Health health;
    public UnityEvent onDestinationReacherd;
    public UnityEvent onStartMoving;

    private bool _isMovingValue;
    public bool IsMoving
    {
        get => _isMovingValue;
        private set
        {
            if (_isMovingValue == value) return;
            _isMovingValue = value;
            OnIsValueChanged();
        }
    }

    private void OnIsValueChanged()
    {
        zomNav.isStopped = !_isMovingValue;
        anim.SetBool("Run", _isMovingValue);
        if(_isMovingValue)
        {
            onStartMoving.Invoke();
        }
        else
        {
            onDestinationReacherd.Invoke();
        }
    }

    private void Move()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        IsMoving = distance > distanceStop;
        if(IsMoving)
        {
            zomNav.SetDestination(player.position);
        }
    }
    private void Update()
    {
        Move();
    }
}
