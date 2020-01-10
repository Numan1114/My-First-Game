using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // we need a variable for lives (in game manager)

    // we need to derease thatg value when we die (in game manager)

    // what does dying look like? What does it mean to die? (in game manager)

    // Transition our scene when we have died (Level Complete)

    public int score { get; private set; }
    public static GameManager INSTANCE;
    public List<string> levelnames;
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public bool gameOver { get; private set; }

    public GameObject completeLevelUI;


    public void Awake()
    {
        if(INSTANCE == null)
        {
            gameOver = false;
            score = 0;
            INSTANCE = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        completeLevelUI = GameObject.Find("Level Complete");
    }

    internal void SetGameOver(bool v)
    {
        gameOver = v;
    }

    private void Start()
    {
        Debug.Log("Hey!");

    }

    public void  CompleteLevel ()
    {
        score = score + Score.score;
        gameOver = true;
        completeLevelUI.SetActive(true);
        completeLevelUI.GetComponent<Animator>().SetBool("LevelComplete", true);

    }


   public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}



