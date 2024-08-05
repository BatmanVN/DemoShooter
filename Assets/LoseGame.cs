using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    [SerializeField] private GameObject GameUI;

    public void ShowLoseUI()
    {
        Time.timeScale = 0;
        GameUI.SetActive(true);
    }
}
