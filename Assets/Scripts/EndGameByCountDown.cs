using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameByCountDown : MonoBehaviour
{

    int countDownValueToExitGame = 0;

    SceneLoader sceneLoader;
    Countdown countDown;

    // Start is called before the first frame update
    void Start()
    {

        sceneLoader = GetComponent<SceneLoader>();
        countDown = GetComponent<Countdown>();

    }

    // Update is called once per frame
    void Update()
    {

        int highscore = PlayerPrefs.GetInt("Highscore");

        if (countDown.GetTimeValue() <= countDownValueToExitGame)
        {

            sceneLoader.LoadScene("EndScreen");

        }

    }

   


}
