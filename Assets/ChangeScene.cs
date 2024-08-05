using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
