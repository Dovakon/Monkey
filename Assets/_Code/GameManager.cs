using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text score;

    private int scoreNumber;

    private static GameManager gameManager;

    public static GameManager instance
    {
        get
        {
            if (!gameManager)
            {
                gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (!gameManager)
                {
                    Debug.Log("There isnt exists an AudioManager on a GameObject in your scene");
                }
            }
            return gameManager;
        }
    }


    public static void HandleScore(int score)
    {
        instance.scoreNumber += score;
        instance.score.text = instance.scoreNumber.ToString();
    }
}
