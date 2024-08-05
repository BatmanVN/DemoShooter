using UnityEngine;

public class ShowGameUI : MonoBehaviour
{
    [SerializeField] private GameObject GameUI;
    
    public void ShowUI()
    {
        Time.timeScale = 1;
        GameUI.SetActive(true);
    }
}
