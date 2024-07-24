using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_enemy : MonoBehaviour
{
    [SerializeField] private float maxHP;
    [SerializeField] private float hP;

    public float MaxHP { get => maxHP; set => maxHP = value; }
    public float HP { get => hP; set => hP = value; }

    public bool Dead => HP <= 0;
    private void Start()
    {
        HP = MaxHP;
    }
    public void TakeDame(float dame)
    {
        if(Dead)
        {
            return;
        }
        else
        {
            HP -= dame;
        }
    }
}
