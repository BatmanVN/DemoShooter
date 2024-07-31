using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    public void WhenDie()
    {
        Time.timeScale = 0;
        Debug.Log("LOSER");
    }
}
