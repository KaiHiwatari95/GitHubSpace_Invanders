using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager manager;
    public Spawner spawner;
    public SceneLoader scene;
    public int level;
    public int maxlevel;

    private void Awake()
    {
        manager = this;
        maxlevel = spawner.hazard.Length - 1;
    }


}
