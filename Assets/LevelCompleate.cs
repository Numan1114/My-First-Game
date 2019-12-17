
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleate : MonoBehaviour
{

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}