using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// [System.Serializable]
public class LoadScene : MonoBehaviour
{

    public string scene;

    public void StartGame()
    {
        // This handles what scene gets loaded up
        SceneManager.LoadScene(scene);

    }
}