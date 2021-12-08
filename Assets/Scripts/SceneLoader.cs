using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{

    public void LoadScene(string _levelName)
    {

        SceneManager.LoadScene(_levelName, LoadSceneMode.Single);

    }

}
