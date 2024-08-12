using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(nameScene);
    }
}
