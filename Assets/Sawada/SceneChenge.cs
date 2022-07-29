using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenge : MonoBehaviour
{
    public void SwitchScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
    }
}