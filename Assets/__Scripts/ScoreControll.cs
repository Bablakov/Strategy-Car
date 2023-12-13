using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControll : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public static int score = 0;

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
