using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string sceneName = "SceneTitle";
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
