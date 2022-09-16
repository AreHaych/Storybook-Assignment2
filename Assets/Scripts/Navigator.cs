using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    public void SceneLoader(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }


    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
