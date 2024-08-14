using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MissionNotification : Singleton<MissionNotification>
{
    [SerializeField] private Text textMission;
    [SerializeField] private ShowUIGame uiGame;
    public int requiredKill;
    private int currentKill;


    private void Start()
    {
        StartCoroutine(VerifyMissions());
    }
    private IEnumerator VerifyMissions()
    {
        yield return VerifyZombieKill();
        uiGame.ShowWinUI();
    }
    private IEnumerator VerifyZombieKill()
    {
        currentKill = 0;
        textMission.text = $"Kill {currentKill}" +"/"+ $"{requiredKill} Zombie";
        yield return new WaitUntil(() => currentKill >= requiredKill); 
    }


    public void OnKilledZombie(GameObject zombie)
    {
        currentKill++;
    }
}
