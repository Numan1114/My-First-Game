
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleate : MonoBehaviour
{
    public List<string> levelnames;
    public int currentLevel = 0;
    public void Start()
    {
        levelnames = GameManager.INSTANCE.levelnames;
    }

    public void LoadNextLevel()
    {
        currentLevel = (currentLevel + 1) % levelnames.Count;
        SceneManager.LoadScene(levelnames[currentLevel]);
    }
}