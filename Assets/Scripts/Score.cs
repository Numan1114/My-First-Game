using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int score;
    public Transform player;
    public Text scoreText;



    void Update()
    {
        Debug.Log(!GameManager.INSTANCE.gameOver);
        if (!GameManager.INSTANCE.gameOver)
        {
            score = (int)player.position.z + GameManager.INSTANCE.score;
            scoreText.text = score + "";
        }
    }
}
