using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{



    public int points = 1;

    void OnDestroy()
    {
        GameScore.AddScore(points);
    }


}
