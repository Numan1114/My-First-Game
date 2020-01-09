﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager INSTANCE;
    public List<string> levelnames;
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;


    public void Awake()
    {
        if(INSTANCE == null)
        {
            INSTANCE = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("Hey!");
        completeLevelUI = GameObject.Find("Level Complete");
        Debug.Log(completeLevelUI.name);
    }

    public void  CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        completeLevelUI.GetComponent<Animator>().SetBool("LevelComplete", true);

    }


   public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
