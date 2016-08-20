using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{

    public GUIText scoreText;
    private int score=0;


	
    void UpdateScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }

    void OnCollisionEnter(Collision collision)
    {
        scoreText.text = "hhhhhhhhhhhhhhhhh " + score;
        if (collision.gameObject.name == "suit_F01")
        {
            Destroy(collision.gameObject);
        }
        UpdateScore();
    }

}
