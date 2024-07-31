using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public AutoFade leftScratch;
    public AutoFade righScratch;

    public void ShowLefScratch() => leftScratch.Show();
    public void ShowRightScratch() => righScratch.Show();
}
