using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIGame : MonoBehaviour
{
    [SerializeField] private GameObject loseUI;
    [SerializeField] private GameObject winUI;
    public void ShowLoseUI()
    {
        StopGame();
        loseUI.SetActive(true);
    }
    public void ShowWinUI()
    {
        StopGame();
        winUI.SetActive(true);
    }
    public void StopGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
