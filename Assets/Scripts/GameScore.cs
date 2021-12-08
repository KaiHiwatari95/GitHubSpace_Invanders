using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    private static int sumScorePoints = 0;
    private static Text display;

    void Awake()
    {
        display = GetComponent<Text>();
    }

    public static void ClearScore()
    {
        sumScorePoints = 0;
        UpdateDisplay();
    }

    public static void AddScore(int points)
    {
        sumScorePoints += points;
        UpdateDisplay();
    }

    public static int GetScore()
    {
        return sumScorePoints;
    }

    private static void UpdateDisplay()
    {
        if (display != null) display.text = sumScorePoints + " Punkte";
        Debug.Log("Aktuelle Punkte: " + sumScorePoints);
    }
}
