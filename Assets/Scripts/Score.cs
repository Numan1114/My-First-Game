using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int score;
    public Transform player;
    public Text scoreText;



    void Update()
    {
        score = (int)player.position.z;
        scoreText.text = score + "";
    }
}
