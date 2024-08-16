using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MissionNotification : Singleton<MissionNotification>
{
    [SerializeField] private Text textMission;
    [SerializeField] private ShowUIGame uiGame;
    [SerializeField] private Gate gate;
    private bool isPlayerExit;
    public int requiredKill;
    private int currentKill;
    private void Start()
    {
        StartCoroutine(VerifyMissions());
    }
    private IEnumerator VerifyMissions()
    {
        yield return VerifyZombieKill();
        yield return VerifyPlayerExit();
        uiGame.ShowWinUI();
    }
    private IEnumerator VerifyZombieKill()
    {
        currentKill = 0;
        textMission.text = $"Mission: Kill {requiredKill} Zombie";
        yield return new WaitUntil(() => currentKill >= requiredKill); 
    }
    
    private IEnumerator VerifyPlayerExit()
    {
        textMission.text = $"FIND DOOR TO EXIT";
        gate.onPlayerEnter.AddListener(OnPlayerExit);
        yield return new WaitUntil(() => isPlayerExit);
        gate.onPlayerEnter.RemoveListener(OnPlayerExit);
    }

    private void OnPlayerExit()
    {
        isPlayerExit = true;
    }

    public void OnKilledZombie(GameObject zombie)
    {
        currentKill++;
    }
}
