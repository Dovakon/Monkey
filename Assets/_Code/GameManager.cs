using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text score;
    public Text timer;

    private int scoreNumber;
    private float startTime;

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


    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer.text = minutes + ":" + seconds; 
    }

    public static void HandleScore(int score)
    {
        instance.scoreNumber += score;
        instance.score.text = instance.scoreNumber.ToString();
    }

    public static void ReachFlag()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
 
    
}
