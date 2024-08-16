using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zom_Attack : MonoBehaviour
{
    public Animator anim;
    public int dame;
    public Health playerhealth;
    public Transform player;


    private void Start()
    {
        player = Player.Instance.playerFoot;
    }
    public void StartAttack()
    {
        transform.LookAt(player);
        playerhealth = Player.Instance.playerHealth;
        anim.SetBool("attack", true);
    }
    public void StopAttack() => anim.SetBool("attack", false);
    public void OnAttack(int index)
    {
        playerhealth.TakeDame(dame);
        if(index == 1)
        {
            Player.Instance.playerUi.ShowLefScratch();
        }
        else
        {
            Player.Instance.playerUi.ShowRightScratch();
        }
    }
}
